; ModuleID = 'obj\Debug\110\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\110\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [350 x i32] [
	i32 26230656, ; 0: Microsoft.Extensions.DependencyModel => 0x1903f80 => 56
	i32 32687329, ; 1: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 126
	i32 34715100, ; 2: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 155
	i32 39109920, ; 3: Newtonsoft.Json.dll => 0x254c520 => 73
	i32 57263871, ; 4: Xamarin.Forms.Core.dll => 0x369c6ff => 150
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 140
	i32 117431740, ; 6: System.Runtime.InteropServices => 0x6ffddbc => 167
	i32 120558881, ; 7: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 140
	i32 159306688, ; 8: System.ComponentModel.Annotations => 0x97ed3c0 => 2
	i32 165246403, ; 9: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 107
	i32 176714968, ; 10: Microsoft.AspNetCore.WebUtilities.dll => 0xa8874d8 => 50
	i32 182336117, ; 11: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 141
	i32 205061960, ; 12: System.ComponentModel => 0xc38ff48 => 21
	i32 209399409, ; 13: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 105
	i32 220171995, ; 14: System.Diagnostics.Debug => 0xd1f8edb => 12
	i32 230216969, ; 15: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 121
	i32 230752869, ; 16: Microsoft.CSharp.dll => 0xdc10265 => 51
	i32 231814094, ; 17: System.Globalization => 0xdd133ce => 15
	i32 232815796, ; 18: System.Web.Services => 0xde07cb4 => 162
	i32 261689757, ; 19: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 110
	i32 278686392, ; 20: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 125
	i32 280482487, ; 21: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 119
	i32 300686228, ; 22: Microsoft.AspNetCore.Authentication.Abstractions.dll => 0x11ec1b94 => 34
	i32 318968648, ; 23: Xamarin.AndroidX.Activity.dll => 0x13031348 => 97
	i32 321597661, ; 24: System.Numerics => 0x132b30dd => 89
	i32 338324308, ; 25: Microsoft.AspNetCore.Mvc.DataAnnotations.dll => 0x142a6b54 => 46
	i32 342366114, ; 26: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 123
	i32 344827588, ; 27: Microsoft.AspNetCore.ResponseCaching.Abstractions => 0x148da6c4 => 47
	i32 384051609, ; 28: Microsoft.AspNetCore.Routing.dll => 0x16e42999 => 49
	i32 385762202, ; 29: System.Memory.dll => 0x16fe439a => 87
	i32 441335492, ; 30: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 109
	i32 442521989, ; 31: Xamarin.Essentials => 0x1a605985 => 149
	i32 442565967, ; 32: System.Collections => 0x1a61054f => 6
	i32 450948140, ; 33: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 118
	i32 465846621, ; 34: mscorlib => 0x1bc4415d => 71
	i32 469710990, ; 35: System.dll => 0x1bff388e => 85
	i32 476646585, ; 36: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 119
	i32 485463106, ; 37: Microsoft.IdentityModel.Abstractions => 0x1cef9442 => 65
	i32 486930444, ; 38: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 130
	i32 490002678, ; 39: Microsoft.AspNetCore.Hosting.Server.Abstractions.dll => 0x1d34d8f6 => 39
	i32 498788369, ; 40: System.ObjectModel => 0x1dbae811 => 171
	i32 513247710, ; 41: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 64
	i32 526420162, ; 42: System.Transactions.dll => 0x1f6088c2 => 157
	i32 530272170, ; 43: System.Linq.Queryable => 0x1f9b4faa => 22
	i32 532697492, ; 44: Syncfusion.SfListView.XForms => 0x1fc05194 => 81
	i32 540030774, ; 45: System.IO.FileSystem.dll => 0x20303736 => 5
	i32 545304856, ; 46: System.Runtime.Extensions => 0x2080b118 => 4
	i32 577335427, ; 47: System.Security.Cryptography.Cng => 0x22697083 => 168
	i32 605376203, ; 48: System.IO.Compression.FileSystem => 0x24154ecb => 160
	i32 610194910, ; 49: System.Reactive.dll => 0x245ed5de => 91
	i32 627609679, ; 50: Xamarin.AndroidX.CustomView => 0x2568904f => 114
	i32 662205335, ; 51: System.Text.Encodings.Web.dll => 0x27787397 => 94
	i32 663517072, ; 52: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 146
	i32 666292255, ; 53: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 102
	i32 690569205, ; 54: System.Xml.Linq.dll => 0x29293ff5 => 96
	i32 695102255, ; 55: Syncfusion.SfListView.XForms.dll => 0x296e6b2f => 81
	i32 719061231, ; 56: Syncfusion.Core.XForms.dll => 0x2adc00ef => 76
	i32 724146010, ; 57: Microsoft.AspNetCore.Authorization.Policy.dll => 0x2b29975a => 37
	i32 775507847, ; 58: System.IO.Compression => 0x2e394f87 => 159
	i32 789151979, ; 59: Microsoft.Extensions.Options => 0x2f0980eb => 63
	i32 809851609, ; 60: System.Drawing.Common.dll => 0x30455ad9 => 19
	i32 843511501, ; 61: Xamarin.AndroidX.Print => 0x3246f6cd => 137
	i32 877678880, ; 62: System.Globalization.dll => 0x34505120 => 15
	i32 928116545, ; 63: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 155
	i32 955402788, ; 64: Newtonsoft.Json => 0x38f24a24 => 73
	i32 967690846, ; 65: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 123
	i32 974778368, ; 66: FormsViewGroup.dll => 0x3a19f000 => 27
	i32 975236339, ; 67: System.Diagnostics.Tracing => 0x3a20ecf3 => 173
	i32 992768348, ; 68: System.Collections.dll => 0x3b2c715c => 6
	i32 994442037, ; 69: System.IO.FileSystem => 0x3b45fb35 => 5
	i32 1012816738, ; 70: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 139
	i32 1028951442, ; 71: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 54
	i32 1035644815, ; 72: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 101
	i32 1042160112, ; 73: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 152
	i32 1044663988, ; 74: System.Linq.Expressions.dll => 0x3e444eb4 => 172
	i32 1052210849, ; 75: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 127
	i32 1086034974, ; 76: Syncfusion.DataSource.Portable.dll => 0x40bb941e => 77
	i32 1098259244, ; 77: System => 0x41761b2c => 85
	i32 1099692271, ; 78: Microsoft.DotNet.PlatformAbstractions => 0x418bf8ef => 52
	i32 1104002344, ; 79: Plugin.Media => 0x41cdbd28 => 74
	i32 1110309514, ; 80: Microsoft.Extensions.Hosting.Abstractions => 0x422dfa8a => 58
	i32 1112354281, ; 81: Microsoft.AspNetCore.Authentication.Abstractions => 0x424d2de9 => 34
	i32 1173126369, ; 82: Microsoft.Extensions.FileProviders.Abstractions.dll => 0x45ec7ce1 => 57
	i32 1175144683, ; 83: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 144
	i32 1178241025, ; 84: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 134
	i32 1186231468, ; 85: Newtonsoft.Json.Bson.dll => 0x46b474ac => 72
	i32 1204270330, ; 86: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 102
	i32 1220193633, ; 87: Microsoft.Net.Http.Headers => 0x48baad61 => 69
	i32 1236289705, ; 88: Microsoft.AspNetCore.Hosting.Server.Abstractions => 0x49b048a9 => 39
	i32 1267360935, ; 89: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 145
	i32 1267908789, ; 90: Microsoft.AspNetCore.Routing => 0x4b92c0b5 => 49
	i32 1292217442, ; 91: Imi.Project.Mobile => 0x4d05ac62 => 32
	i32 1293217323, ; 92: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 116
	i32 1324164729, ; 93: System.Linq => 0x4eed2679 => 9
	i32 1327812513, ; 94: Howest.Prog.Xamarin.UriSourceExtensions.dll => 0x4f24cfa1 => 30
	i32 1364015309, ; 95: System.IO => 0x514d38cd => 8
	i32 1365406463, ; 96: System.ServiceModel.Internals.dll => 0x516272ff => 164
	i32 1376866003, ; 97: Xamarin.AndroidX.SavedState => 0x52114ed3 => 139
	i32 1379779777, ; 98: System.Resources.ResourceManager => 0x523dc4c1 => 17
	i32 1395857551, ; 99: Xamarin.AndroidX.Media.dll => 0x5333188f => 131
	i32 1406073936, ; 100: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 111
	i32 1411638395, ; 101: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 92
	i32 1418299235, ; 102: FreshIOC => 0x54898763 => 28
	i32 1457743152, ; 103: System.Runtime.Extensions.dll => 0x56e36530 => 4
	i32 1460219004, ; 104: Xamarin.Forms.Xaml => 0x57092c7c => 153
	i32 1460893475, ; 105: System.IdentityModel.Tokens.Jwt => 0x57137723 => 86
	i32 1462112819, ; 106: System.IO.Compression.dll => 0x57261233 => 159
	i32 1469204771, ; 107: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 100
	i32 1470490898, ; 108: Microsoft.Extensions.Primitives => 0x57a5e912 => 64
	i32 1496693446, ; 109: Syncfusion.SfListView.XForms.Android => 0x5935bac6 => 80
	i32 1498168481, ; 110: Microsoft.IdentityModel.JsonWebTokens.dll => 0x594c3ca1 => 66
	i32 1516315406, ; 111: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 75
	i32 1518685258, ; 112: Imi.Project.Mobile.Android.dll => 0x5a854c4a => 0
	i32 1543031311, ; 113: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 169
	i32 1548254347, ; 114: Imi.Project.Mobile.dll => 0x5c487c8b => 32
	i32 1550322496, ; 115: System.Reflection.Extensions.dll => 0x5c680b40 => 18
	i32 1565862583, ; 116: System.IO.FileSystem.Primitives => 0x5d552ab7 => 10
	i32 1582372066, ; 117: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 115
	i32 1592978981, ; 118: System.Runtime.Serialization.dll => 0x5ef2ee25 => 25
	i32 1600077045, ; 119: FreshMvvm.dll => 0x5f5f3cf5 => 29
	i32 1622152042, ; 120: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 129
	i32 1622358360, ; 121: System.Dynamic.Runtime => 0x60b33958 => 170
	i32 1624863272, ; 122: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 148
	i32 1636350590, ; 123: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 113
	i32 1639515021, ; 124: System.Net.Http.dll => 0x61b9038d => 24
	i32 1639986890, ; 125: System.Text.RegularExpressions => 0x61c036ca => 169
	i32 1657153582, ; 126: System.Runtime => 0x62c6282e => 93
	i32 1658241508, ; 127: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 142
	i32 1658251792, ; 128: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 154
	i32 1670060433, ; 129: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 110
	i32 1701541528, ; 130: System.Diagnostics.Debug.dll => 0x656b7698 => 12
	i32 1726116996, ; 131: System.Reflection.dll => 0x66e27484 => 7
	i32 1729485958, ; 132: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 106
	i32 1765942094, ; 133: System.Reflection.Extensions => 0x6942234e => 18
	i32 1766324549, ; 134: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 141
	i32 1776026572, ; 135: System.Core.dll => 0x69dc03cc => 83
	i32 1788241197, ; 136: Xamarin.AndroidX.Fragment => 0x6a96652d => 118
	i32 1808609942, ; 137: Xamarin.AndroidX.Loader => 0x6bcd3296 => 129
	i32 1813201214, ; 138: Xamarin.Google.Android.Material => 0x6c13413e => 154
	i32 1818569960, ; 139: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 135
	i32 1819327070, ; 140: Microsoft.AspNetCore.Http.Features.dll => 0x6c70ba5e => 43
	i32 1824175904, ; 141: System.Text.Encoding.Extensions => 0x6cbab720 => 16
	i32 1828688058, ; 142: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 61
	i32 1858542181, ; 143: System.Linq.Expressions => 0x6ec71a65 => 172
	i32 1867746548, ; 144: Xamarin.Essentials.dll => 0x6f538cf4 => 149
	i32 1878053835, ; 145: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 153
	i32 1885316902, ; 146: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 103
	i32 1894524299, ; 147: Microsoft.DotNet.PlatformAbstractions.dll => 0x70ec258b => 52
	i32 1900610850, ; 148: System.Resources.ResourceManager.dll => 0x71490522 => 17
	i32 1904755420, ; 149: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 23
	i32 1919157823, ; 150: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 132
	i32 1928288591, ; 151: Microsoft.AspNetCore.Http.Abstractions => 0x72ef594f => 40
	i32 1942524222, ; 152: Imi.Project.Mobile.Android => 0x73c8913e => 0
	i32 1986222447, ; 153: Microsoft.IdentityModel.Tokens.dll => 0x7663596f => 68
	i32 1987243864, ; 154: FluentValidation => 0x7672ef58 => 26
	i32 2011961780, ; 155: System.Buffers.dll => 0x77ec19b4 => 82
	i32 2019465201, ; 156: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 127
	i32 2048185678, ; 157: Plugin.Media.dll => 0x7a14d54e => 74
	i32 2055257422, ; 158: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 124
	i32 2069514766, ; 159: Newtonsoft.Json.Bson => 0x7b5a4a0e => 72
	i32 2075706075, ; 160: Microsoft.AspNetCore.Http.Abstractions.dll => 0x7bb8c2db => 40
	i32 2079903147, ; 161: System.Runtime.dll => 0x7bf8cdab => 93
	i32 2090596640, ; 162: System.Numerics.Vectors => 0x7c9bf920 => 90
	i32 2097448633, ; 163: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 120
	i32 2126786730, ; 164: Xamarin.Forms.Platform.Android => 0x7ec430aa => 151
	i32 2181898931, ; 165: Microsoft.Extensions.Options.dll => 0x820d22b3 => 63
	i32 2182738860, ; 166: Microsoft.AspNetCore.Mvc.Core.dll => 0x8219f3ac => 45
	i32 2192057212, ; 167: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 61
	i32 2193016926, ; 168: System.ObjectModel.dll => 0x82b6c85e => 171
	i32 2197979891, ; 169: Microsoft.Extensions.DependencyModel.dll => 0x830282f3 => 56
	i32 2201231467, ; 170: System.Net.Http => 0x8334206b => 24
	i32 2204417087, ; 171: Microsoft.Extensions.ObjectPool => 0x8364bc3f => 62
	i32 2217644978, ; 172: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 144
	i32 2242871324, ; 173: Microsoft.AspNetCore.Http.dll => 0x85af801c => 41
	i32 2244775296, ; 174: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 130
	i32 2256548716, ; 175: Xamarin.AndroidX.MultiDex => 0x8680336c => 132
	i32 2261435625, ; 176: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 122
	i32 2266799131, ; 177: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 53
	i32 2279755925, ; 178: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 138
	i32 2285293097, ; 179: Microsoft.AspNetCore.Mvc.Abstractions => 0x8836ce29 => 44
	i32 2315684594, ; 180: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 98
	i32 2321784778, ; 181: Microsoft.AspNetCore.Mvc.Abstractions.dll => 0x8a639fca => 44
	i32 2340441535, ; 182: System.Runtime.InteropServices.RuntimeInformation.dll => 0x8b804dbf => 166
	i32 2343171156, ; 183: Syncfusion.Core.XForms => 0x8ba9f454 => 76
	i32 2354730003, ; 184: Syncfusion.Licensing => 0x8c5a5413 => 79
	i32 2369706906, ; 185: Microsoft.IdentityModel.Logging => 0x8d3edb9a => 67
	i32 2392818924, ; 186: System.Net.Http.Formatting.dll => 0x8e9f84ec => 88
	i32 2409053734, ; 187: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 136
	i32 2435904999, ; 188: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 163
	i32 2454642406, ; 189: System.Text.Encoding.dll => 0x924edee6 => 13
	i32 2458592288, ; 190: Microsoft.AspNetCore.Authentication.Core => 0x928b2420 => 35
	i32 2465532216, ; 191: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 109
	i32 2471215200, ; 192: ImageCircle.Forms.Plugin => 0x934bc060 => 31
	i32 2471841756, ; 193: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 194: Java.Interop.dll => 0x93918882 => 33
	i32 2490993605, ; 195: System.AppContext.dll => 0x94798bc5 => 3
	i32 2501346920, ; 196: System.Data.DataSetExtensions => 0x95178668 => 158
	i32 2505896520, ; 197: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 126
	i32 2515096885, ; 198: Syncfusion.DataSource.Portable => 0x95e95535 => 77
	i32 2537015816, ; 199: Microsoft.AspNetCore.Authorization => 0x9737ca08 => 36
	i32 2562349572, ; 200: Microsoft.CSharp => 0x98ba5a04 => 51
	i32 2570120770, ; 201: System.Text.Encodings.Web => 0x9930ee42 => 94
	i32 2581819634, ; 202: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 145
	i32 2585220780, ; 203: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 16
	i32 2592341985, ; 204: Microsoft.Extensions.FileProviders.Abstractions => 0x9a83ffe1 => 57
	i32 2593268061, ; 205: Microsoft.AspNetCore.Routing.Abstractions.dll => 0x9a92215d => 48
	i32 2594125473, ; 206: Microsoft.AspNetCore.Hosting.Abstractions => 0x9a9f36a1 => 38
	i32 2620871830, ; 207: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 113
	i32 2624644809, ; 208: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 117
	i32 2633051222, ; 209: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 125
	i32 2633959305, ; 210: Microsoft.AspNetCore.Http.Extensions.dll => 0x9cff0789 => 42
	i32 2640290731, ; 211: Microsoft.IdentityModel.Logging.dll => 0x9d5fa3ab => 67
	i32 2693849962, ; 212: System.IO.dll => 0xa090e36a => 8
	i32 2701096212, ; 213: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 142
	i32 2715334215, ; 214: System.Threading.Tasks.dll => 0xa1d8b647 => 11
	i32 2719963679, ; 215: System.Security.Cryptography.Cng.dll => 0xa21f5a1f => 168
	i32 2724373263, ; 216: System.Runtime.Numerics.dll => 0xa262a30f => 14
	i32 2732626843, ; 217: Xamarin.AndroidX.Activity => 0xa2e0939b => 97
	i32 2735631878, ; 218: Microsoft.AspNetCore.Authorization.dll => 0xa30e6e06 => 36
	i32 2737747696, ; 219: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 100
	i32 2760020586, ; 220: Howest.Prog.Xamarin.UriSourceExtensions => 0xa482926a => 30
	i32 2766581644, ; 221: Xamarin.Forms.Core => 0xa4e6af8c => 150
	i32 2778768386, ; 222: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 147
	i32 2810250172, ; 223: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 111
	i32 2819470561, ; 224: System.Xml.dll => 0xa80db4e1 => 95
	i32 2850549256, ; 225: Microsoft.AspNetCore.Http.Features => 0xa9e7ee08 => 43
	i32 2853208004, ; 226: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 147
	i32 2855708567, ; 227: Xamarin.AndroidX.Transition => 0xaa36a797 => 143
	i32 2868557005, ; 228: Syncfusion.Licensing.dll => 0xaafab4cd => 79
	i32 2874148507, ; 229: Syncfusion.Core.XForms.Android => 0xab50069b => 75
	i32 2900621748, ; 230: System.Dynamic.Runtime.dll => 0xace3f9b4 => 170
	i32 2901442782, ; 231: System.Reflection => 0xacf080de => 7
	i32 2903344695, ; 232: System.ComponentModel.Composition => 0xad0d8637 => 161
	i32 2905242038, ; 233: mscorlib.dll => 0xad2a79b6 => 71
	i32 2916838712, ; 234: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 148
	i32 2919462931, ; 235: System.Numerics.Vectors.dll => 0xae037813 => 90
	i32 2921128767, ; 236: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 99
	i32 2959614098, ; 237: System.ComponentModel.dll => 0xb0682092 => 21
	i32 2978368250, ; 238: Microsoft.AspNetCore.Hosting.Abstractions.dll => 0xb1864afa => 38
	i32 2978675010, ; 239: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 116
	i32 2996646946, ; 240: Microsoft.AspNetCore.Http => 0xb29d3422 => 41
	i32 3024354802, ; 241: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 121
	i32 3033331042, ; 242: Microsoft.AspNetCore.Authentication.Core.dll => 0xb4ccf562 => 35
	i32 3036999524, ; 243: Microsoft.AspNetCore.Http.Extensions => 0xb504ef64 => 42
	i32 3044182254, ; 244: FormsViewGroup => 0xb57288ee => 27
	i32 3057625584, ; 245: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 133
	i32 3075834255, ; 246: System.Threading.Tasks => 0xb755818f => 11
	i32 3084678329, ; 247: Microsoft.IdentityModel.Tokens => 0xb7dc74b9 => 68
	i32 3111772706, ; 248: System.Runtime.Serialization => 0xb979e222 => 25
	i32 3113762169, ; 249: Microsoft.AspNetCore.Routing.Abstractions => 0xb9983d79 => 48
	i32 3124832203, ; 250: System.Threading.Tasks.Extensions => 0xba4127cb => 165
	i32 3147165239, ; 251: System.Diagnostics.Tracing.dll => 0xbb95ee37 => 173
	i32 3151576809, ; 252: Microsoft.AspNetCore.Mvc.Core => 0xbbd93ee9 => 45
	i32 3204380047, ; 253: System.Data.dll => 0xbefef58f => 156
	i32 3211777861, ; 254: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 115
	i32 3220365878, ; 255: System.Threading => 0xbff2e236 => 20
	i32 3228018376, ; 256: Microsoft.AspNetCore.ResponseCaching.Abstractions.dll => 0xc067a6c8 => 47
	i32 3247949154, ; 257: Mono.Security => 0xc197c562 => 174
	i32 3258312781, ; 258: Xamarin.AndroidX.CardView => 0xc235e84d => 106
	i32 3265493905, ; 259: System.Linq.Queryable.dll => 0xc2a37b91 => 22
	i32 3265893370, ; 260: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 165
	i32 3267021929, ; 261: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 104
	i32 3280506390, ; 262: System.ComponentModel.Annotations.dll => 0xc3888e16 => 2
	i32 3299363146, ; 263: System.Text.Encoding => 0xc4a8494a => 13
	i32 3300764913, ; 264: Microsoft.AspNetCore.WebUtilities => 0xc4bdacf1 => 50
	i32 3312457198, ; 265: Microsoft.IdentityModel.JsonWebTokens => 0xc57015ee => 66
	i32 3317135071, ; 266: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 114
	i32 3317144872, ; 267: System.Data => 0xc5b79d28 => 156
	i32 3340431453, ; 268: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 103
	i32 3346324047, ; 269: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 134
	i32 3353484488, ; 270: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 120
	i32 3361254415, ; 271: FreshIOC.dll => 0xc858ac0f => 28
	i32 3362522851, ; 272: Xamarin.AndroidX.Core => 0xc86c06e3 => 112
	i32 3366347497, ; 273: Java.Interop => 0xc8a662e9 => 33
	i32 3374999561, ; 274: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 138
	i32 3395150330, ; 275: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 92
	i32 3404865022, ; 276: System.ServiceModel.Internals => 0xcaf21dfe => 164
	i32 3428513518, ; 277: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 55
	i32 3429136800, ; 278: System.Xml => 0xcc6479a0 => 95
	i32 3430777524, ; 279: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 280: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 117
	i32 3448958507, ; 281: Syncfusion.GridCommon.Portable.dll => 0xcd92ee2b => 78
	i32 3476120550, ; 282: Mono.Android => 0xcf3163e6 => 70
	i32 3483112796, ; 283: ImageCircle.Forms.Plugin.dll => 0xcf9c155c => 31
	i32 3486566296, ; 284: System.Transactions => 0xcfd0c798 => 157
	i32 3493954962, ; 285: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 108
	i32 3501239056, ; 286: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 104
	i32 3509114376, ; 287: System.Xml.Linq => 0xd128d608 => 96
	i32 3536029504, ; 288: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 151
	i32 3567349600, ; 289: System.ComponentModel.Composition.dll => 0xd4a16f60 => 161
	i32 3592435036, ; 290: Microsoft.Extensions.Localization.Abstractions => 0xd620355c => 59
	i32 3608519521, ; 291: System.Linq.dll => 0xd715a361 => 9
	i32 3618140916, ; 292: Xamarin.AndroidX.Preference => 0xd7a872f4 => 136
	i32 3623953038, ; 293: FluentValidation.dll => 0xd801228e => 26
	i32 3624195450, ; 294: System.Runtime.InteropServices.RuntimeInformation => 0xd804d57a => 166
	i32 3627220390, ; 295: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 137
	i32 3632359727, ; 296: Xamarin.Forms.Platform => 0xd881692f => 152
	i32 3633644679, ; 297: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 99
	i32 3638274909, ; 298: System.IO.FileSystem.Primitives.dll => 0xd8dbab5d => 10
	i32 3641597786, ; 299: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 124
	i32 3645089577, ; 300: System.ComponentModel.DataAnnotations => 0xd943a729 => 163
	i32 3657292374, ; 301: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 53
	i32 3672681054, ; 302: Mono.Android.dll => 0xdae8aa5e => 70
	i32 3676310014, ; 303: System.Web.Services.dll => 0xdb2009fe => 162
	i32 3682565725, ; 304: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 105
	i32 3684561358, ; 305: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 108
	i32 3684933406, ; 306: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 23
	i32 3689375977, ; 307: System.Drawing.Common => 0xdbe768e9 => 19
	i32 3700591436, ; 308: Microsoft.IdentityModel.Abstractions.dll => 0xdc928b4c => 65
	i32 3718780102, ; 309: Xamarin.AndroidX.Annotation => 0xdda814c6 => 98
	i32 3724971120, ; 310: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 133
	i32 3731644420, ; 311: System.Reactive => 0xde6c6004 => 91
	i32 3748608112, ; 312: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 84
	i32 3758932259, ; 313: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 122
	i32 3765508441, ; 314: Microsoft.Extensions.ObjectPool.dll => 0xe0711959 => 62
	i32 3776403777, ; 315: Microsoft.Extensions.Localization.Abstractions.dll => 0xe1175941 => 59
	i32 3786282454, ; 316: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 107
	i32 3822602673, ; 317: Xamarin.AndroidX.Media => 0xe3d849b1 => 131
	i32 3829621856, ; 318: System.Numerics.dll => 0xe4436460 => 89
	i32 3837938240, ; 319: Syncfusion.SfListView.XForms.Android.dll => 0xe4c24a40 => 80
	i32 3841636137, ; 320: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 54
	i32 3849253459, ; 321: System.Runtime.InteropServices.dll => 0xe56ef253 => 167
	i32 3885922214, ; 322: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 143
	i32 3896760992, ; 323: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 112
	i32 3898971068, ; 324: Microsoft.Extensions.Localization.dll => 0xe86593bc => 60
	i32 3920810846, ; 325: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 160
	i32 3921031405, ; 326: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 146
	i32 3931092270, ; 327: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 135
	i32 3945713374, ; 328: System.Data.DataSetExtensions.dll => 0xeb2ecede => 158
	i32 3954195687, ; 329: Microsoft.Extensions.Localization => 0xebb03ce7 => 60
	i32 3955647286, ; 330: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 101
	i32 4025784931, ; 331: System.Memory => 0xeff49a63 => 87
	i32 4044155772, ; 332: Microsoft.Net.Http.Headers.dll => 0xf10ceb7c => 69
	i32 4051712506, ; 333: Syncfusion.GridCommon.Portable => 0xf18039fa => 78
	i32 4073602200, ; 334: System.Threading.dll => 0xf2ce3c98 => 20
	i32 4078967171, ; 335: Microsoft.Extensions.Hosting.Abstractions.dll => 0xf3201983 => 58
	i32 4105002889, ; 336: Mono.Security.dll => 0xf4ad5f89 => 174
	i32 4126470640, ; 337: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 55
	i32 4130442656, ; 338: System.AppContext => 0xf6318da0 => 3
	i32 4131741489, ; 339: System.Net.Http.Formatting => 0xf6455f31 => 88
	i32 4141580284, ; 340: Microsoft.AspNetCore.Authorization.Policy => 0xf6db7ffc => 37
	i32 4151237749, ; 341: System.Core => 0xf76edc75 => 83
	i32 4151317942, ; 342: FreshMvvm => 0xf77015b6 => 29
	i32 4182413190, ; 343: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 128
	i32 4213026141, ; 344: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 84
	i32 4258913604, ; 345: Microsoft.AspNetCore.Mvc.DataAnnotations => 0xfdd9dd44 => 46
	i32 4260525087, ; 346: System.Buffers => 0xfdf2741f => 82
	i32 4263231520, ; 347: System.IdentityModel.Tokens.Jwt.dll => 0xfe1bc020 => 86
	i32 4274976490, ; 348: System.Runtime.Numerics => 0xfecef6ea => 14
	i32 4292120959 ; 349: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 128
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [350 x i32] [
	i32 56, i32 126, i32 155, i32 73, i32 150, i32 140, i32 167, i32 140, ; 0..7
	i32 2, i32 107, i32 50, i32 141, i32 21, i32 105, i32 12, i32 121, ; 8..15
	i32 51, i32 15, i32 162, i32 110, i32 125, i32 119, i32 34, i32 97, ; 16..23
	i32 89, i32 46, i32 123, i32 47, i32 49, i32 87, i32 109, i32 149, ; 24..31
	i32 6, i32 118, i32 71, i32 85, i32 119, i32 65, i32 130, i32 39, ; 32..39
	i32 171, i32 64, i32 157, i32 22, i32 81, i32 5, i32 4, i32 168, ; 40..47
	i32 160, i32 91, i32 114, i32 94, i32 146, i32 102, i32 96, i32 81, ; 48..55
	i32 76, i32 37, i32 159, i32 63, i32 19, i32 137, i32 15, i32 155, ; 56..63
	i32 73, i32 123, i32 27, i32 173, i32 6, i32 5, i32 139, i32 54, ; 64..71
	i32 101, i32 152, i32 172, i32 127, i32 77, i32 85, i32 52, i32 74, ; 72..79
	i32 58, i32 34, i32 57, i32 144, i32 134, i32 72, i32 102, i32 69, ; 80..87
	i32 39, i32 145, i32 49, i32 32, i32 116, i32 9, i32 30, i32 8, ; 88..95
	i32 164, i32 139, i32 17, i32 131, i32 111, i32 92, i32 28, i32 4, ; 96..103
	i32 153, i32 86, i32 159, i32 100, i32 64, i32 80, i32 66, i32 75, ; 104..111
	i32 0, i32 169, i32 32, i32 18, i32 10, i32 115, i32 25, i32 29, ; 112..119
	i32 129, i32 170, i32 148, i32 113, i32 24, i32 169, i32 93, i32 142, ; 120..127
	i32 154, i32 110, i32 12, i32 7, i32 106, i32 18, i32 141, i32 83, ; 128..135
	i32 118, i32 129, i32 154, i32 135, i32 43, i32 16, i32 61, i32 172, ; 136..143
	i32 149, i32 153, i32 103, i32 52, i32 17, i32 23, i32 132, i32 40, ; 144..151
	i32 0, i32 68, i32 26, i32 82, i32 127, i32 74, i32 124, i32 72, ; 152..159
	i32 40, i32 93, i32 90, i32 120, i32 151, i32 63, i32 45, i32 61, ; 160..167
	i32 171, i32 56, i32 24, i32 62, i32 144, i32 41, i32 130, i32 132, ; 168..175
	i32 122, i32 53, i32 138, i32 44, i32 98, i32 44, i32 166, i32 76, ; 176..183
	i32 79, i32 67, i32 88, i32 136, i32 163, i32 13, i32 35, i32 109, ; 184..191
	i32 31, i32 1, i32 33, i32 3, i32 158, i32 126, i32 77, i32 36, ; 192..199
	i32 51, i32 94, i32 145, i32 16, i32 57, i32 48, i32 38, i32 113, ; 200..207
	i32 117, i32 125, i32 42, i32 67, i32 8, i32 142, i32 11, i32 168, ; 208..215
	i32 14, i32 97, i32 36, i32 100, i32 30, i32 150, i32 147, i32 111, ; 216..223
	i32 95, i32 43, i32 147, i32 143, i32 79, i32 75, i32 170, i32 7, ; 224..231
	i32 161, i32 71, i32 148, i32 90, i32 99, i32 21, i32 38, i32 116, ; 232..239
	i32 41, i32 121, i32 35, i32 42, i32 27, i32 133, i32 11, i32 68, ; 240..247
	i32 25, i32 48, i32 165, i32 173, i32 45, i32 156, i32 115, i32 20, ; 248..255
	i32 47, i32 174, i32 106, i32 22, i32 165, i32 104, i32 2, i32 13, ; 256..263
	i32 50, i32 66, i32 114, i32 156, i32 103, i32 134, i32 120, i32 28, ; 264..271
	i32 112, i32 33, i32 138, i32 92, i32 164, i32 55, i32 95, i32 1, ; 272..279
	i32 117, i32 78, i32 70, i32 31, i32 157, i32 108, i32 104, i32 96, ; 280..287
	i32 151, i32 161, i32 59, i32 9, i32 136, i32 26, i32 166, i32 137, ; 288..295
	i32 152, i32 99, i32 10, i32 124, i32 163, i32 53, i32 70, i32 162, ; 296..303
	i32 105, i32 108, i32 23, i32 19, i32 65, i32 98, i32 133, i32 91, ; 304..311
	i32 84, i32 122, i32 62, i32 59, i32 107, i32 131, i32 89, i32 80, ; 312..319
	i32 54, i32 167, i32 143, i32 112, i32 60, i32 160, i32 146, i32 135, ; 320..327
	i32 158, i32 60, i32 101, i32 87, i32 69, i32 78, i32 20, i32 58, ; 328..335
	i32 174, i32 55, i32 3, i32 88, i32 37, i32 83, i32 29, i32 128, ; 336..343
	i32 84, i32 46, i32 82, i32 86, i32 14, i32 128 ; 344..349
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
