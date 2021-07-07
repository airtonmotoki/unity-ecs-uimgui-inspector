﻿using Unity.Mathematics;

namespace UImGuiManager.EntitiesInspector
{
	public partial class UImGuiEntityInspectorWindow
	{
		public void DrawComponent(float2x2 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
		}

		public void DrawComponent(float2x3 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
			DrawComponent(obj.c2);
		}

		public void DrawComponent(float2x4 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
			DrawComponent(obj.c2);
			DrawComponent(obj.c3);
		}

		public void DrawComponent(float3x2 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
		}

		public void DrawComponent(float3x3 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
			DrawComponent(obj.c2);
		}

		public void DrawComponent(float3x4 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
			DrawComponent(obj.c2);
			DrawComponent(obj.c3);
		}

		public void DrawComponent(float4x2 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
		}

		public void DrawComponent(float4x3 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
			DrawComponent(obj.c2);
		}

		public void DrawComponent(float4x4 obj)
		{
			DrawComponent(obj.c0);
			DrawComponent(obj.c1);
			DrawComponent(obj.c2);
			DrawComponent(obj.c3);
		}
	}
}
