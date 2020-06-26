//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/StencilSurface" {
Properties {
_Color ("Main Color", Color) = (1,1,1,1)
_BackColor ("Backside Color", Color) = (1,1,1,1)
_LocalScale ("Local Scale", Vector) = (1,1,1,1)
_GridSize ("Grid Size", Float) = 1
_GridWidth ("Grid Width", Float) = 0.05
_UVGridWidth ("UV Grid Width", Float) = 0.1
[KeywordEnum(Cube, Sphere, Capsule)] _Shape ("Shape Type", Float) = 0
}
SubShader {
 LOD 100
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "TransparentCutout" }
 Pass {
  LOD 100
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "TransparentCutout" }
  ZWrite Off
  Cull Front
  GpuProgramID 4235
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  LOD 100
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "TransparentCutout" }
  ZWrite Off
  GpuProgramID 125547
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CUBE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_SPHERE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HIGHLIGHT_ON" "_SHAPE_CAPSULE" }
"// shader disassembly not supported on DXBC"
}
}
}
}
Fallback "Unlit/Diffuse"
}