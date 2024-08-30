Shader "Unlit/UnlitShader"
{
    Properties
    {
        
        _MainTex ("Texture", 2D) = "white" {}
        _Intensity("Intensity", Range(0,1))= 0.5
        _Color ("Color", Color)= (1,1,1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100
        

        Pass
        {
            CGPROGRAM /// codigo de shaders HSLS
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata ///del mesh a vertices
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f ///datos que van del que modifica vertices a color.
            {
                float2 uv : TEXCOORD0;
               
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 Color;
            float4 _Intensity;



            v2f vert (appdata v)//// por vertice ( mueve los vertices).
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target //// por color ( modifica el color).
            {
                
                fixed4 col = tex2D(_MainTex, i.uv);
                col=col* Color;
                return col;
                //col.r=1, col.x=1 el rgb (se puede cambiar por x,y,z).
                //col.gb=1 col.yz=1
            }
            ENDCG
        }
    }
}
