//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/ColorPicker_sv_h" {
Properties {
_Color ("Main Color", Color) = (1,1,1,1)
_Slider01 ("Slider", Range(0, 1)) = 0.5
}
SubShader {
 LOD 100
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "AlphaTest+20" "RenderType" = "TransparentCutout" }
 Pass {
  LOD 100
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "AlphaTest+20" "RenderType" = "TransparentCutout" }
  GpuProgramID 43980
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  LOD 100
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "AlphaTest+20" "RenderType" = "TransparentCutout" }
  GpuProgramID 89603
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
}
}