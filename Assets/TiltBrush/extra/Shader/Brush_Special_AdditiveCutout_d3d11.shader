//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Brush/Special/AdditiveCutout" {
Properties {
_MainTex ("Texture", 2D) = "white" { }
_Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
}
SubShader {
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
 Pass {
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
  ZWrite Off
  Cull Off
  GpuProgramID 16635
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}