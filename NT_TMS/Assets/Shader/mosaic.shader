// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/mosaic" {
    Properties
    {
        //[PerRendererData]
        _MainTex ("Texture", 2D) = "white" {}
        _Width ("Image Width", Float) = 256
        _Height ("Image Height", Float) = 256
        _BlockWidth ("Block Width", Float) = 2
        _BlockHeight ("Block Height", Float) = 2
    }
    SubShader
    {
        Tags {
            "RenderType"="Opaque"
        }
        Cull Off Lighting Off Fog { Mode Off }
        AlphaTest Off Blend Off
        ZWrite Off
        LOD 200

        Pass {
CGPROGRAM
#pragma vertex vert
#pragma fragment frag
#pragma fragmentoption ARB_precision_hint_fastest
#include "UnityCG.cginc"

            struct v2f {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            sampler2D _MainTex;
            float4    _MainTex_ST; // xy : Scale, zw : Offset(Transform)
            float _Width;
            float _Height;
            float _BlockWidth;
            float _BlockHeight;

            v2f vert(appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos (v.vertex);
                o.uv  = v.texcoord + _MainTex_ST.zw;// offset 値だけ反映
                //o.uv  = TRANSFORM_TEX(v.texcoord, _MainTex);// scale, offset を両方反映するならばマクロあり。(v.texcoord * _MainTex_ST.xy + _MainTex_ST.zw)
                return o;
            }

            fixed4 frag( v2f i ) : COLOR
            {
                // ブロックの先頭のピクセル値を反映する.
                i.uv.x = floor((i.uv.x * _Width) / _BlockWidth) * _BlockWidth / _Width;
                i.uv.y = floor((i.uv.y * _Height) / _BlockHeight) * _BlockHeight / _Height;
                return tex2D(_MainTex, i.uv);
            }
ENDCG
        }
    }
}
