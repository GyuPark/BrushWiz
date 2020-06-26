//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Brush/Special/AdditiveScrolling" {
Properties {
_TintColor ("Tint Color", Color) = (0.5,0.5,0.5,0.5)
_MainTex ("Particle Texture", 2D) = "white" { }
_ScrollRate ("Scroll Rate", Float) = 1
_ScrollDistance ("Scroll Distance", Vector) = (1,0,0,1)
_ScrollJitterIntensity ("Scroll Jitter Intensity", Float) = 1
_ScrollJitterFrequency ("Scroll Jitter Frequency", Float) = 1
_FalloffPower ("Falloff Power", Float) = 2
}
SubShader {
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
 Pass {
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
  ZWrite Off
  Cull Off
  GpuProgramID 60232
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}