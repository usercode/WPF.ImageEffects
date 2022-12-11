sampler2D Input : register(S0);
float brightness : register(c0);
float contrast : register(c1);

float4 main(float2 uv : TEXCOORD) : COLOR
{
	float4 color = tex2D(Input, uv);

	color.rgb /= color.a;
	color.rgb += brightness;
	color.rgb = ((color.rgb - 0.5) * pow((contrast + 1.0), 2)) + 0.5;
	color.rgb *= color.a;

	return color;
}