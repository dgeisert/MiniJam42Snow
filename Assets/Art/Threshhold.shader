Shader "VertexColorUnlit" {
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert fullforwardshadows vertex:vert finalcolor:mycolor
		#pragma target 3.0

		struct Input {
			float4 vertColor;
		};

		void vert(inout appdata_full v, out Input o){
			UNITY_INITIALIZE_OUTPUT(Input, o);
			o.vertColor = v.color;
		}

		void surf (Input IN, inout SurfaceOutput o) {
			o.Albedo = IN.vertColor.rgb;
		}
        void mycolor (Input IN, SurfaceOutput o, inout fixed4 color)
        {
            color = (color.r + color.g + color.b) > 0.5 ? float4(1,1,1,1) : float4(0,0,0,1);
        }
		ENDCG
	}
	FallBack "Diffuse"
}