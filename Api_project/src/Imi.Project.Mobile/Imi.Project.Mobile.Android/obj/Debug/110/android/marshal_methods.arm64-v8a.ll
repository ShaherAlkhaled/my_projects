; ModuleID = 'obj\Debug\110\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\110\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [350 x i64] [
	i64 15690660930947125, ; 0: Microsoft.DotNet.PlatformAbstractions.dll => 0x37be92af148835 => 52
	i64 24362543149721218, ; 1: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 117
	i64 98382396393917666, ; 2: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 64
	i64 120698629574877762, ; 3: Mono.Android => 0x1accec39cafe242 => 70
	i64 160518225272466977, ; 4: Microsoft.Extensions.Hosting.Abstractions => 0x23a4679b5576e21 => 58
	i64 195258733703605363, ; 5: System.Net.Http.Formatting => 0x2b5b2c8a5b22c73 => 88
	i64 196720943101637631, ; 6: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 172
	i64 210515253464952879, ; 7: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 107
	i64 232391251801502327, ; 8: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 139
	i64 295915112840604065, ; 9: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 140
	i64 347331204332682223, ; 10: ImageCircle.Forms.Plugin => 0x4d1f7e3dda87bef => 31
	i64 464346026994987652, ; 11: System.Reactive.dll => 0x671b04057e67284 => 91
	i64 535107122908063503, ; 12: Microsoft.Extensions.ObjectPool.dll => 0x76d1517d9b7670f => 62
	i64 634308326490598313, ; 13: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 126
	i64 702024105029695270, ; 14: System.Drawing.Common => 0x9be17343c0e7726 => 19
	i64 720058930071658100, ; 15: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 120
	i64 774222078205450857, ; 16: Syncfusion.SfListView.XForms.Android => 0xabe96e0ccb35a69 => 80
	i64 799765834175365804, ; 17: System.ComponentModel.dll => 0xb1956c9f18442ac => 21
	i64 827515161936339185, ; 18: FreshIOC => 0xb7beca7c97720f1 => 28
	i64 864641107619353643, ; 19: Microsoft.AspNetCore.Mvc.DataAnnotations => 0xbffd2819dda142b => 46
	i64 872800313462103108, ; 20: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 116
	i64 940822596282819491, ; 21: System.Transactions => 0xd0e792aa81923a3 => 157
	i64 982068613551266738, ; 22: Microsoft.AspNetCore.ResponseCaching.Abstractions.dll => 0xda1023367c89bb2 => 47
	i64 996343623809489702, ; 23: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 152
	i64 1000557547492888992, ; 24: Mono.Security.dll => 0xde2b1c9cba651a0 => 174
	i64 1001381392624924420, ; 25: Microsoft.AspNetCore.Authentication.Core.dll => 0xde59f1230183704 => 35
	i64 1120440138749646132, ; 26: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 154
	i64 1212813105769650772, ; 27: Syncfusion.DataSource.Portable => 0x10d4c7180c569a54 => 77
	i64 1315114680217950157, ; 28: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 102
	i64 1425944114962822056, ; 29: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 25
	i64 1624659445732251991, ; 30: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 100
	i64 1628611045998245443, ; 31: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 128
	i64 1636321030536304333, ; 32: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 121
	i64 1731380447121279447, ; 33: Newtonsoft.Json => 0x18071957e9b889d7 => 73
	i64 1743969030606105336, ; 34: System.Memory.dll => 0x1833d297e88f2af8 => 87
	i64 1795316252682057001, ; 35: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 101
	i64 1825687700144851180, ; 36: System.Runtime.InteropServices.RuntimeInformation.dll => 0x1956254a55ef08ec => 166
	i64 1836611346387731153, ; 37: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 139
	i64 1875917498431009007, ; 38: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 98
	i64 1981742497975770890, ; 39: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 127
	i64 2040001226662520565, ; 40: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 165
	i64 2076847052340733488, ; 41: Syncfusion.Core.XForms => 0x1cd27163f7962630 => 76
	i64 2126915263223078201, ; 42: Syncfusion.GridCommon.Portable => 0x1d845229bbc49d39 => 78
	i64 2133195048986300728, ; 43: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 73
	i64 2136356949452311481, ; 44: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 132
	i64 2165725771938924357, ; 45: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 105
	i64 2262844636196693701, ; 46: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 116
	i64 2284400282711631002, ; 47: System.Web.Services => 0x1fb3d1f42fd4249a => 162
	i64 2287887973817120656, ; 48: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 163
	i64 2315304989185124968, ; 49: System.IO.FileSystem.dll => 0x20219d9ee311aa68 => 5
	i64 2329709569556905518, ; 50: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 124
	i64 2335503487726329082, ; 51: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 94
	i64 2337758774805907496, ; 52: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 92
	i64 2469392061734276978, ; 53: Syncfusion.Core.XForms.Android.dll => 0x22450aff2ad74f72 => 75
	i64 2470498323731680442, ; 54: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 111
	i64 2479423007379663237, ; 55: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 144
	i64 2497223385847772520, ; 56: System.Runtime => 0x22a7eb7046413568 => 93
	i64 2547086958574651984, ; 57: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 97
	i64 2592350477072141967, ; 58: System.Xml.dll => 0x23f9e10627330e8f => 95
	i64 2612152650457191105, ; 59: Microsoft.IdentityModel.Tokens.dll => 0x24403afeed9892c1 => 68
	i64 2624866290265602282, ; 60: mscorlib.dll => 0x246d65fbde2db8ea => 71
	i64 2656907746661064104, ; 61: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 55
	i64 2694427813909235223, ; 62: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 136
	i64 2713070138985274548, ; 63: Syncfusion.SfListView.XForms.Android.dll => 0x25a6c2eabcefdcb4 => 80
	i64 2783046991838674048, ; 64: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 92
	i64 2789714023057451704, ; 65: Microsoft.IdentityModel.JsonWebTokens.dll => 0x26b70e1f9943eab8 => 66
	i64 2960931600190307745, ; 66: Xamarin.Forms.Core => 0x2917579a49927da1 => 150
	i64 3017704767998173186, ; 67: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 154
	i64 3021884968805928991, ; 68: Microsoft.AspNetCore.Authorization.Policy => 0x29efe45e55c5101f => 37
	i64 3168817962471953758, ; 69: Microsoft.Extensions.Hosting.Abstractions.dll => 0x2bf9e725d304955e => 58
	i64 3266690593535380875, ; 70: Microsoft.AspNetCore.Authorization => 0x2d559dc982c94d8b => 36
	i64 3284784939149891983, ; 71: Imi.Project.Mobile.Android.dll => 0x2d95e67fa595198f => 0
	i64 3289520064315143713, ; 72: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 123
	i64 3303437397778967116, ; 73: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 99
	i64 3311221304742556517, ; 74: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 90
	i64 3325875462027654285, ; 75: System.Runtime.Numerics => 0x2e27e21c8958b48d => 14
	i64 3396143930648122816, ; 76: Microsoft.Extensions.FileProviders.Abstractions => 0x2f2186e9506155c0 => 57
	i64 3402534845034375023, ; 77: System.IdentityModel.Tokens.Jwt.dll => 0x2f383b6a0629a76f => 86
	i64 3493805808809882663, ; 78: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 142
	i64 3522470458906976663, ; 79: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 141
	i64 3531994851595924923, ; 80: System.Numerics => 0x31042a9aade235bb => 89
	i64 3571415421602489686, ; 81: System.Runtime.dll => 0x319037675df7e556 => 93
	i64 3638003163729360188, ; 82: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 53
	i64 3716579019761409177, ; 83: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 84: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 138
	i64 3730887114094830029, ; 85: Syncfusion.GridCommon.Portable.dll => 0x33c6c6102cb461cd => 78
	i64 3772598417116884899, ; 86: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 117
	i64 3966267475168208030, ; 87: System.Memory => 0x370b03412596249e => 87
	i64 4154383907710350974, ; 88: System.ComponentModel => 0x39a7562737acb67e => 21
	i64 4187479170553454871, ; 89: System.Linq.Expressions => 0x3a1cea1e912fa117 => 172
	i64 4202567570116092282, ; 90: Newtonsoft.Json.Bson => 0x3a5284f05958a17a => 72
	i64 4225924121207573736, ; 91: Microsoft.AspNetCore.Authentication.Abstractions => 0x3aa57f992c550ce8 => 34
	i64 4243591448627561453, ; 92: Microsoft.AspNetCore.Http.Extensions.dll => 0x3ae443f06354c3ed => 42
	i64 4250192876909962317, ; 93: Microsoft.AspNetCore.Hosting.Abstractions => 0x3afbb7e72f1d244d => 38
	i64 4525561845656915374, ; 94: System.ServiceModel.Internals => 0x3ece06856b710dae => 164
	i64 4636684751163556186, ; 95: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 146
	i64 4645756877833507374, ; 96: Imi.Project.Mobile.dll => 0x40790b442018122e => 32
	i64 4743821336939966868, ; 97: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 2
	i64 4782108999019072045, ; 98: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 104
	i64 4794310189461587505, ; 99: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 97
	i64 4795410492532947900, ; 100: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 141
	i64 4984589564328971462, ; 101: FluentValidation => 0x452cd1cc9cf28cc6 => 26
	i64 5081566143765835342, ; 102: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 17
	i64 5099468265966638712, ; 103: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 17
	i64 5112836352847824253, ; 104: Microsoft.AspNetCore.WebUtilities.dll => 0x46f47192ee32c57d => 50
	i64 5142919913060024034, ; 105: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 151
	i64 5177565741364132164, ; 106: Microsoft.AspNetCore.Http => 0x47da689c1f3db944 => 41
	i64 5202753749449073649, ; 107: Plugin.Media => 0x4833e4f841be63f1 => 74
	i64 5203618020066742981, ; 108: Xamarin.Essentials => 0x4836f704f0e652c5 => 149
	i64 5205316157927637098, ; 109: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 130
	i64 5348796042099802469, ; 110: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 131
	i64 5359521160085360696, ; 111: FreshIOC.dll => 0x4a60d8196113d038 => 28
	i64 5376510917114486089, ; 112: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 144
	i64 5404556524862317797, ; 113: FluentValidation.dll => 0x4b00d78658f024e5 => 26
	i64 5408338804355907810, ; 114: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 143
	i64 5423376490970181369, ; 115: System.Runtime.InteropServices.RuntimeInformation => 0x4b43b42f2b7b6ef9 => 166
	i64 5446034149219586269, ; 116: System.Diagnostics.Debug => 0x4b94333452e150dd => 12
	i64 5451019430259338467, ; 117: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 110
	i64 5507995362134886206, ; 118: System.Core.dll => 0x4c705499688c873e => 83
	i64 5527431512186326818, ; 119: System.IO.FileSystem.Primitives.dll => 0x4cb561acbc2a8f22 => 10
	i64 5593115988096097561, ; 120: Microsoft.AspNetCore.Routing.dll => 0x4d9ebd5b8a069d19 => 49
	i64 5610815111739789596, ; 121: Microsoft.AspNetCore.Authentication.Core => 0x4ddd9e9de3a4d11c => 35
	i64 5633126816028165141, ; 122: FreshMvvm => 0x4e2ce2fe5c160415 => 29
	i64 5692067934154308417, ; 123: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 148
	i64 5741990095351817038, ; 124: Microsoft.Extensions.Localization.Abstractions.dll => 0x4fafa591c141a34e => 59
	i64 5757522595884336624, ; 125: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 108
	i64 5814345312393086621, ; 126: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 136
	i64 5896680224035167651, ; 127: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 125
	i64 6085203216496545422, ; 128: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 152
	i64 6086316965293125504, ; 129: FormsViewGroup.dll => 0x5476f10882baef80 => 27
	i64 6319713645133255417, ; 130: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 126
	i64 6401687960814735282, ; 131: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 124
	i64 6465768060024492319, ; 132: Syncfusion.SfListView.XForms => 0x59bb05cb21d3911f => 81
	i64 6504860066809920875, ; 133: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 105
	i64 6548213210057960872, ; 134: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 114
	i64 6560151584539558821, ; 135: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 63
	i64 6591024623626361694, ; 136: System.Web.Services.dll => 0x5b7805f9751a1b5e => 162
	i64 6659513131007730089, ; 137: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 120
	i64 6876862101832370452, ; 138: System.Xml.Linq => 0x5f6f85a57d108914 => 96
	i64 6894844156784520562, ; 139: System.Numerics.Vectors => 0x5faf683aead1ad72 => 90
	i64 6911788284027924527, ; 140: Microsoft.AspNetCore.Hosting.Server.Abstractions => 0x5feb9ad2f830f02f => 39
	i64 7026608356547306326, ; 141: Syncfusion.Core.XForms.dll => 0x618387125bcb2356 => 76
	i64 7036436454368433159, ; 142: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 122
	i64 7103753931438454322, ; 143: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 119
	i64 7112547816752919026, ; 144: System.IO.FileSystem => 0x62b4d88e3189b1f2 => 5
	i64 7129514256229348874, ; 145: Imi.Project.Mobile.Android => 0x62f11f7137a2360a => 0
	i64 7141577505875122296, ; 146: System.Runtime.InteropServices.WindowsRuntime.dll => 0x631bfae7659b5878 => 23
	i64 7270811800166795866, ; 147: System.Linq => 0x64e71ccf51a90a5a => 9
	i64 7331765743953618630, ; 148: Microsoft.AspNetCore.Http.dll => 0x65bfaa1948bba6c6 => 41
	i64 7338192458477945005, ; 149: System.Reflection => 0x65d67f295d0740ad => 7
	i64 7473077275758116397, ; 150: Microsoft.DotNet.PlatformAbstractions => 0x67b5b430309b3e2d => 52
	i64 7488575175965059935, ; 151: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 96
	i64 7489048572193775167, ; 152: System.ObjectModel => 0x67ee71ff6b419e3f => 171
	i64 7496222613193209122, ; 153: System.IdentityModel.Tokens.Jwt => 0x6807eec000a1b522 => 86
	i64 7602111570124318452, ; 154: System.Reactive => 0x698020320025a6f4 => 91
	i64 7635363394907363464, ; 155: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 150
	i64 7637365915383206639, ; 156: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 149
	i64 7654504624184590948, ; 157: System.Net.Http => 0x6a3a4366801b8264 => 24
	i64 7735176074855944702, ; 158: Microsoft.CSharp => 0x6b58dda848e391fe => 51
	i64 7820441508502274321, ; 159: System.Data => 0x6c87ca1e14ff8111 => 156
	i64 7824823231109474690, ; 160: Microsoft.AspNetCore.Authorization.Policy.dll => 0x6c975b4560812982 => 37
	i64 7836164640616011524, ; 161: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 100
	i64 8044118961405839122, ; 162: System.ComponentModel.Composition => 0x6fa2739369944712 => 161
	i64 8064050204834738623, ; 163: System.Collections.dll => 0x6fe942efa61731bf => 6
	i64 8083354569033831015, ; 164: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 123
	i64 8087206902342787202, ; 165: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 84
	i64 8103644804370223335, ; 166: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 158
	i64 8113615946733131500, ; 167: System.Reflection.Extensions => 0x70995ab73cf916ec => 18
	i64 8167236081217502503, ; 168: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 33
	i64 8185542183669246576, ; 169: System.Collections => 0x7198e33f4794aa70 => 6
	i64 8290740647658429042, ; 170: System.Runtime.Extensions => 0x730ea0b15c929a72 => 4
	i64 8318905602908530212, ; 171: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 163
	i64 8398329775253868912, ; 172: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 109
	i64 8400357532724379117, ; 173: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 135
	i64 8519205576476231015, ; 174: Microsoft.AspNetCore.Mvc.Core.dll => 0x763a4c55ca648567 => 45
	i64 8601935802264776013, ; 175: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 143
	i64 8611142787134128904, ; 176: Microsoft.AspNetCore.Hosting.Server.Abstractions.dll => 0x7780ecbdb94c0308 => 39
	i64 8626175481042262068, ; 177: Java.Interop => 0x77b654e585b55834 => 33
	i64 8638972117149407195, ; 178: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 51
	i64 8639588376636138208, ; 179: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 134
	i64 8684531736582871431, ; 180: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 160
	i64 8725526185868997716, ; 181: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 84
	i64 8849523176203181611, ; 182: Howest.Prog.Xamarin.UriSourceExtensions => 0x7acfd271252d5e2b => 30
	i64 9312692141327339315, ; 183: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 148
	i64 9324707631942237306, ; 184: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 101
	i64 9413000421947348542, ; 185: Microsoft.AspNetCore.Hosting.Abstractions.dll => 0x82a1b202f4c6163e => 38
	i64 9427266486299436557, ; 186: Microsoft.IdentityModel.Logging.dll => 0x82d460ebe6d2a60d => 67
	i64 9584643793929893533, ; 187: System.IO.dll => 0x85037ebfbbd7f69d => 8
	i64 9659729154652888475, ; 188: System.Text.RegularExpressions => 0x860e407c9991dd9b => 169
	i64 9662334977499516867, ; 189: System.Numerics.dll => 0x8617827802b0cfc3 => 89
	i64 9678050649315576968, ; 190: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 111
	i64 9711637524876806384, ; 191: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 131
	i64 9808709177481450983, ; 192: Mono.Android.dll => 0x881f890734e555e7 => 70
	i64 9825649861376906464, ; 193: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 108
	i64 9834056768316610435, ; 194: System.Transactions.dll => 0x8879968718899783 => 157
	i64 9933555792566666578, ; 195: System.Linq.Queryable.dll => 0x89db145cf475c552 => 22
	i64 9938556199016768930, ; 196: Microsoft.AspNetCore.Routing => 0x89ecd834cea6a5a2 => 49
	i64 9994308163963284983, ; 197: Newtonsoft.Json.Bson.dll => 0x8ab2ea52b0d16df7 => 72
	i64 9998632235833408227, ; 198: Mono.Security => 0x8ac2470b209ebae3 => 174
	i64 10038780035334861115, ; 199: System.Net.Http.dll => 0x8b50e941206af13b => 24
	i64 10229024438826829339, ; 200: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 114
	i64 10243523786148452761, ; 201: Microsoft.AspNetCore.Http.Abstractions => 0x8e284e9c69a49999 => 40
	i64 10360651442923773544, ; 202: System.Text.Encoding => 0x8fc86d98211c1e68 => 13
	i64 10376576884623852283, ; 203: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 142
	i64 10430153318873392755, ; 204: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 112
	i64 10458986597687352396, ; 205: Microsoft.AspNetCore.Routing.Abstractions => 0x9125c8e581b9dc4c => 48
	i64 10566960649245365243, ; 206: System.Globalization.dll => 0x92a562b96dcd13fb => 15
	i64 10714184849103829812, ; 207: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 4
	i64 10822644899632537592, ; 208: System.Linq.Queryable => 0x9631c23204ca5ff8 => 22
	i64 10847732767863316357, ; 209: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 102
	i64 10943211539042655480, ; 210: FreshMvvm.dll => 0x97de18ea4697dcf8 => 29
	i64 10964653383833615866, ; 211: System.Diagnostics.Tracing => 0x982a4628ccaffdfa => 173
	i64 11002576679268595294, ; 212: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 61
	i64 11023048688141570732, ; 213: System.Core => 0x98f9bc61168392ac => 83
	i64 11037814507248023548, ; 214: System.Xml => 0x992e31d0412bf7fc => 95
	i64 11050168729868392624, ; 215: Microsoft.AspNetCore.Http.Features => 0x995a15e9dbef58b0 => 43
	i64 11162124722117608902, ; 216: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 147
	i64 11226290749488709958, ; 217: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 63
	i64 11340910727871153756, ; 218: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 113
	i64 11392833485892708388, ; 219: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 137
	i64 11432101114902388181, ; 220: System.AppContext => 0x9ea6fb64e61a9dd5 => 3
	i64 11485890710487134646, ; 221: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 167
	i64 11517440453979132662, ; 222: Microsoft.IdentityModel.Abstractions.dll => 0x9fd62b122523d2f6 => 65
	i64 11529969570048099689, ; 223: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 147
	i64 11578238080964724296, ; 224: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 122
	i64 11580057168383206117, ; 225: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 98
	i64 11597940890313164233, ; 226: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 227: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 119
	i64 11743665907891708234, ; 228: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 11
	i64 12102847907131387746, ; 229: System.Buffers => 0xa7f5f40c43256f62 => 82
	i64 12123043025855404482, ; 230: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 18
	i64 12137774235383566651, ; 231: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 145
	i64 12310909314810916455, ; 232: Microsoft.Extensions.Localization.dll => 0xaad922cbbb5a2e67 => 60
	i64 12439275739440478309, ; 233: Microsoft.IdentityModel.JsonWebTokens => 0xaca12f61007bf865 => 66
	i64 12441092376399691269, ; 234: Microsoft.AspNetCore.Authentication.Abstractions.dll => 0xaca7a399c11fbe05 => 34
	i64 12451044538927396471, ; 235: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 118
	i64 12466513435562512481, ; 236: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 129
	i64 12487638416075308985, ; 237: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 115
	i64 12538491095302438457, ; 238: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 106
	i64 12550732019250633519, ; 239: System.IO.Compression => 0xae2d28465e8e1b2f => 159
	i64 12700543734426720211, ; 240: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 107
	i64 12708238894395270091, ; 241: System.IO => 0xb05cbbf17d3ba3cb => 8
	i64 12708922737231849740, ; 242: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 16
	i64 12843321153144804894, ; 243: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 64
	i64 12843770487262409629, ; 244: System.AppContext.dll => 0xb23e3d357debf39d => 3
	i64 12963446364377008305, ; 245: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 19
	i64 13308002692117796025, ; 246: Microsoft.AspNetCore.Routing.Abstractions.dll => 0xb8af85f08d9f94b9 => 48
	i64 13370592475155966277, ; 247: System.Runtime.Serialization => 0xb98de304062ea945 => 25
	i64 13401370062847626945, ; 248: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 145
	i64 13404347523447273790, ; 249: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 109
	i64 13404984788036896679, ; 250: Microsoft.AspNetCore.Http.Abstractions.dll => 0xba0812a45e7447a7 => 40
	i64 13454009404024712428, ; 251: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 155
	i64 13491513212026656886, ; 252: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 103
	i64 13550417756503177631, ; 253: Microsoft.Extensions.FileProviders.Abstractions.dll => 0xbc0cc1280684799f => 57
	i64 13572454107664307259, ; 254: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 138
	i64 13618112415141049676, ; 255: Microsoft.AspNetCore.Mvc.Core => 0xbcfd4116f7d1b54c => 45
	i64 13619343573712272001, ; 256: Howest.Prog.Xamarin.UriSourceExtensions.dll => 0xbd01a0d2691e7a81 => 30
	i64 13622732128915678507, ; 257: Syncfusion.Core.XForms.Android => 0xbd0daab1e651e52b => 75
	i64 13643785327914841093, ; 258: Plugin.Media.dll => 0xbd587677c60cf405 => 74
	i64 13647894001087880694, ; 259: System.Data.dll => 0xbd670f48cb071df6 => 156
	i64 13713329104121190199, ; 260: System.Dynamic.Runtime => 0xbe4f8829f32b5737 => 170
	i64 13852575513600495870, ; 261: ImageCircle.Forms.Plugin.dll => 0xc03e3c09186e90fe => 31
	i64 13921917134693230900, ; 262: Microsoft.AspNetCore.WebUtilities => 0xc13495df5dd06934 => 50
	i64 13955418299340266673, ; 263: Microsoft.Extensions.DependencyModel.dll => 0xc1ab9b0118299cb1 => 56
	i64 13959074834287824816, ; 264: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 118
	i64 13967638549803255703, ; 265: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 151
	i64 13970307180132182141, ; 266: Syncfusion.Licensing => 0xc1e0805ccade287d => 79
	i64 14124974489674258913, ; 267: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 106
	i64 14125464355221830302, ; 268: System.Threading.dll => 0xc407bafdbc707a9e => 20
	i64 14172845254133543601, ; 269: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 132
	i64 14212104595480609394, ; 270: System.Security.Cryptography.Cng.dll => 0xc53b89d4a4518272 => 168
	i64 14254574811015963973, ; 271: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 16
	i64 14261073672896646636, ; 272: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 137
	i64 14261232074598307362, ; 273: Microsoft.AspNetCore.Mvc.Abstractions => 0xc5ea130339d6d622 => 44
	i64 14327695147300244862, ; 274: System.Reflection.dll => 0xc6d632d338eb4d7e => 7
	i64 14486659737292545672, ; 275: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 125
	i64 14528548208938697926, ; 276: Microsoft.AspNetCore.Mvc.Abstractions.dll => 0xc99fc59ed7edc4c6 => 44
	i64 14538127318538747197, ; 277: Syncfusion.Licensing.dll => 0xc9c1cdc518e77d3d => 79
	i64 14551742072151931844, ; 278: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 94
	i64 14644440854989303794, ; 279: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 130
	i64 14669215534098758659, ; 280: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 55
	i64 14792063746108907174, ; 281: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 155
	i64 14852515768018889994, ; 282: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 113
	i64 14954917835170835695, ; 283: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 54
	i64 14987728460634540364, ; 284: System.IO.Compression.dll => 0xcfff1ba06622494c => 159
	i64 14988210264188246988, ; 285: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 115
	i64 15076659072870671916, ; 286: System.ObjectModel.dll => 0xd13b0d8c1620662c => 171
	i64 15133485256822086103, ; 287: System.Linq.dll => 0xd204f0a9127dd9d7 => 9
	i64 15138356091203993725, ; 288: Microsoft.IdentityModel.Abstractions => 0xd2163ea89395c07d => 65
	i64 15227001540531775957, ; 289: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 53
	i64 15234786388537674379, ; 290: System.Dynamic.Runtime.dll => 0xd36cd580c5be8a8b => 170
	i64 15332518387094693223, ; 291: Microsoft.AspNetCore.Mvc.DataAnnotations.dll => 0xd4c80c3ce6eca567 => 46
	i64 15370028218478381000, ; 292: Microsoft.Extensions.Localization.Abstractions => 0xd54d4f3b162247c8 => 59
	i64 15370334346939861994, ; 293: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 112
	i64 15391712275433856905, ; 294: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 54
	i64 15526743539506359484, ; 295: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 13
	i64 15565247197164990907, ; 296: Microsoft.AspNetCore.Http.Extensions => 0xd802dddb8c29f1bb => 42
	i64 15582737692548360875, ; 297: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 128
	i64 15592226634512578529, ; 298: Microsoft.AspNetCore.Authorization.dll => 0xd862b7834f81b7e1 => 36
	i64 15609085926864131306, ; 299: System.dll => 0xd89e9cf3334914ea => 85
	i64 15620595871140898079, ; 300: Microsoft.Extensions.DependencyModel => 0xd8c7812eef49651f => 56
	i64 15735700225633954557, ; 301: Microsoft.Extensions.Localization => 0xda606ffbe0f22afd => 60
	i64 15755368083429170162, ; 302: System.IO.FileSystem.Primitives => 0xdaa64fcbde529bf2 => 10
	i64 15777549416145007739, ; 303: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 140
	i64 15810740023422282496, ; 304: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 153
	i64 15817206913877585035, ; 305: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 11
	i64 15852824340364052161, ; 306: Microsoft.AspNetCore.Http.Features.dll => 0xdc008bbee610c6c1 => 43
	i64 15937190497610202713, ; 307: System.Security.Cryptography.Cng => 0xdd2c465197c97e59 => 168
	i64 15963349826457351533, ; 308: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 165
	i64 16046481083542319511, ; 309: Microsoft.Extensions.ObjectPool => 0xdeb08d870f90b197 => 62
	i64 16154507427712707110, ; 310: System => 0xe03056ea4e39aa26 => 85
	i64 16321164108206115771, ; 311: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 61
	i64 16344871930018146979, ; 312: Microsoft.AspNetCore.ResponseCaching.Abstractions => 0xe2d4a66be7fc2aa3 => 47
	i64 16565028646146589191, ; 313: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 161
	i64 16621146507174665210, ; 314: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 110
	i64 16677317093839702854, ; 315: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 135
	i64 16740690081460163056, ; 316: Syncfusion.DataSource.Portable.dll => 0xe852e0eee05691f0 => 77
	i64 16822611501064131242, ; 317: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 158
	i64 16833383113903931215, ; 318: mscorlib => 0xe99c30c1484d7f4f => 71
	i64 16866861824412579935, ; 319: System.Runtime.InteropServices.WindowsRuntime => 0xea132176ffb5785f => 23
	i64 16890310621557459193, ; 320: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 169
	i64 17024911836938395553, ; 321: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 99
	i64 17031351772568316411, ; 322: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 133
	i64 17037200463775726619, ; 323: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 121
	i64 17126545051278881272, ; 324: Microsoft.Net.Http.Headers.dll => 0xedadb5fbdb33b1f8 => 69
	i64 17137864900836977098, ; 325: Microsoft.IdentityModel.Tokens => 0xedd5ed53b705e9ca => 68
	i64 17187273293601214786, ; 326: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 2
	i64 17333249706306540043, ; 327: System.Diagnostics.Tracing.dll => 0xf08c12c5bb8b920b => 173
	i64 17338600258603746468, ; 328: Syncfusion.SfListView.XForms.dll => 0xf09f1512449284a4 => 81
	i64 17544493274320527064, ; 329: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 104
	i64 17627500474728259406, ; 330: System.Globalization => 0xf4a176498a351f4e => 15
	i64 17685921127322830888, ; 331: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 12
	i64 17704177640604968747, ; 332: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 129
	i64 17710060891934109755, ; 333: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 127
	i64 17712670374920797664, ; 334: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 167
	i64 17727188866493996799, ; 335: System.Net.Http.Formatting.dll => 0xf603a059f5a25eff => 88
	i64 17777860260071588075, ; 336: System.Runtime.Numerics.dll => 0xf6b7a5b72419c0eb => 14
	i64 17790600151040787804, ; 337: Microsoft.IdentityModel.Logging => 0xf6e4e89427cc055c => 67
	i64 17838668724098252521, ; 338: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 82
	i64 17882897186074144999, ; 339: FormsViewGroup => 0xf82cd03e3ac830e7 => 27
	i64 17892495832318972303, ; 340: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 153
	i64 17911643751311784505, ; 341: Microsoft.Net.Http.Headers => 0xf892f1178448ba39 => 69
	i64 17928294245072900555, ; 342: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 160
	i64 18025913125965088385, ; 343: System.Threading => 0xfa28e87b91334681 => 20
	i64 18116111925905154859, ; 344: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 103
	i64 18121036031235206392, ; 345: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 133
	i64 18129453464017766560, ; 346: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 164
	i64 18305135509493619199, ; 347: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 134
	i64 18355722495993441458, ; 348: Imi.Project.Mobile => 0xfebca05b7955ecb2 => 32
	i64 18380184030268848184 ; 349: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 146
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [350 x i32] [
	i32 52, i32 117, i32 64, i32 70, i32 58, i32 88, i32 172, i32 107, ; 0..7
	i32 139, i32 140, i32 31, i32 91, i32 62, i32 126, i32 19, i32 120, ; 8..15
	i32 80, i32 21, i32 28, i32 46, i32 116, i32 157, i32 47, i32 152, ; 16..23
	i32 174, i32 35, i32 154, i32 77, i32 102, i32 25, i32 100, i32 128, ; 24..31
	i32 121, i32 73, i32 87, i32 101, i32 166, i32 139, i32 98, i32 127, ; 32..39
	i32 165, i32 76, i32 78, i32 73, i32 132, i32 105, i32 116, i32 162, ; 40..47
	i32 163, i32 5, i32 124, i32 94, i32 92, i32 75, i32 111, i32 144, ; 48..55
	i32 93, i32 97, i32 95, i32 68, i32 71, i32 55, i32 136, i32 80, ; 56..63
	i32 92, i32 66, i32 150, i32 154, i32 37, i32 58, i32 36, i32 0, ; 64..71
	i32 123, i32 99, i32 90, i32 14, i32 57, i32 86, i32 142, i32 141, ; 72..79
	i32 89, i32 93, i32 53, i32 1, i32 138, i32 78, i32 117, i32 87, ; 80..87
	i32 21, i32 172, i32 72, i32 34, i32 42, i32 38, i32 164, i32 146, ; 88..95
	i32 32, i32 2, i32 104, i32 97, i32 141, i32 26, i32 17, i32 17, ; 96..103
	i32 50, i32 151, i32 41, i32 74, i32 149, i32 130, i32 131, i32 28, ; 104..111
	i32 144, i32 26, i32 143, i32 166, i32 12, i32 110, i32 83, i32 10, ; 112..119
	i32 49, i32 35, i32 29, i32 148, i32 59, i32 108, i32 136, i32 125, ; 120..127
	i32 152, i32 27, i32 126, i32 124, i32 81, i32 105, i32 114, i32 63, ; 128..135
	i32 162, i32 120, i32 96, i32 90, i32 39, i32 76, i32 122, i32 119, ; 136..143
	i32 5, i32 0, i32 23, i32 9, i32 41, i32 7, i32 52, i32 96, ; 144..151
	i32 171, i32 86, i32 91, i32 150, i32 149, i32 24, i32 51, i32 156, ; 152..159
	i32 37, i32 100, i32 161, i32 6, i32 123, i32 84, i32 158, i32 18, ; 160..167
	i32 33, i32 6, i32 4, i32 163, i32 109, i32 135, i32 45, i32 143, ; 168..175
	i32 39, i32 33, i32 51, i32 134, i32 160, i32 84, i32 30, i32 148, ; 176..183
	i32 101, i32 38, i32 67, i32 8, i32 169, i32 89, i32 111, i32 131, ; 184..191
	i32 70, i32 108, i32 157, i32 22, i32 49, i32 72, i32 174, i32 24, ; 192..199
	i32 114, i32 40, i32 13, i32 142, i32 112, i32 48, i32 15, i32 4, ; 200..207
	i32 22, i32 102, i32 29, i32 173, i32 61, i32 83, i32 95, i32 43, ; 208..215
	i32 147, i32 63, i32 113, i32 137, i32 3, i32 167, i32 65, i32 147, ; 216..223
	i32 122, i32 98, i32 1, i32 119, i32 11, i32 82, i32 18, i32 145, ; 224..231
	i32 60, i32 66, i32 34, i32 118, i32 129, i32 115, i32 106, i32 159, ; 232..239
	i32 107, i32 8, i32 16, i32 64, i32 3, i32 19, i32 48, i32 25, ; 240..247
	i32 145, i32 109, i32 40, i32 155, i32 103, i32 57, i32 138, i32 45, ; 248..255
	i32 30, i32 75, i32 74, i32 156, i32 170, i32 31, i32 50, i32 56, ; 256..263
	i32 118, i32 151, i32 79, i32 106, i32 20, i32 132, i32 168, i32 16, ; 264..271
	i32 137, i32 44, i32 7, i32 125, i32 44, i32 79, i32 94, i32 130, ; 272..279
	i32 55, i32 155, i32 113, i32 54, i32 159, i32 115, i32 171, i32 9, ; 280..287
	i32 65, i32 53, i32 170, i32 46, i32 59, i32 112, i32 54, i32 13, ; 288..295
	i32 42, i32 128, i32 36, i32 85, i32 56, i32 60, i32 10, i32 140, ; 296..303
	i32 153, i32 11, i32 43, i32 168, i32 165, i32 62, i32 85, i32 61, ; 304..311
	i32 47, i32 161, i32 110, i32 135, i32 77, i32 158, i32 71, i32 23, ; 312..319
	i32 169, i32 99, i32 133, i32 121, i32 69, i32 68, i32 2, i32 173, ; 320..327
	i32 81, i32 104, i32 15, i32 12, i32 129, i32 127, i32 167, i32 88, ; 328..335
	i32 14, i32 67, i32 82, i32 27, i32 153, i32 69, i32 160, i32 20, ; 336..343
	i32 103, i32 133, i32 164, i32 134, i32 32, i32 146 ; 344..349
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
