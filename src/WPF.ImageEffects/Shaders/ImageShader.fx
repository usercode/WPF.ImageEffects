sampler2D Input : register(S0);
float brightness : register(c0);
float contrast : register(c1);

float4 main(float2 uv : TEXCOORD) : COLOR
{
	float4 texColor = tex2D(Input, uv);
	float4 final = texColor;
	final = texColor + brightness;
	//final = final * pow((contrast + 1.0) / 1.0, 2);
	final = ((final - 0.5) * pow((contrast + 1.0) / 1.0, 2)) + 0.5;

	final.a = texColor.a; //restore alpha value

	return final;
}