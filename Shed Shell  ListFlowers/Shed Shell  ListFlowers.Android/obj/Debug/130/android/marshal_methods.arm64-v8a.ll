; ModuleID = 'obj\Debug\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.arm64-v8a.ll"
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
@assembly_image_cache_hashes = local_unnamed_addr constant [264 x i64] [
	i64 15690660930947125, ; 0: Microsoft.DotNet.PlatformAbstractions.dll => 0x37be92af148835 => 15
	i64 24362543149721218, ; 1: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 77
	i64 98382396393917666, ; 2: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 32
	i64 120698629574877762, ; 3: Mono.Android => 0x1accec39cafe242 => 33
	i64 210515253464952879, ; 4: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 67
	i64 232391251801502327, ; 5: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 99
	i64 295915112840604065, ; 6: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 100
	i64 438653063886580349, ; 7: Shed Shell  ListFlowers => 0x61668a33498aa7d => 35
	i64 634308326490598313, ; 8: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 86
	i64 668723562677762733, ; 9: Microsoft.Extensions.Configuration.Binder.dll => 0x947c88986577aad => 24
	i64 702024105029695270, ; 10: System.Drawing.Common => 0x9be17343c0e7726 => 119
	i64 720058930071658100, ; 11: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 80
	i64 870603111519317375, ; 12: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 38
	i64 872800313462103108, ; 13: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 76
	i64 940822596282819491, ; 14: System.Transactions => 0xd0e792aa81923a3 => 117
	i64 996343623809489702, ; 15: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 112
	i64 1000557547492888992, ; 16: Mono.Security.dll => 0xde2b1c9cba651a0 => 130
	i64 1010800728818218806, ; 17: Microsoft.Bcl.HashCode.dll => 0xe0715e84bea7736 => 11
	i64 1120440138749646132, ; 18: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 114
	i64 1278906455852160409, ; 19: Microsoft.EntityFrameworkCore.SqlServer.dll => 0x11bf96a54a059599 => 20
	i64 1301485588176585670, ; 20: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 37
	i64 1315114680217950157, ; 21: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 62
	i64 1425944114962822056, ; 22: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 52
	i64 1518315023656898250, ; 23: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 39
	i64 1624659445732251991, ; 24: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 60
	i64 1628611045998245443, ; 25: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 88
	i64 1636321030536304333, ; 26: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 81
	i64 1672383392659050004, ; 27: Microsoft.Data.Sqlite.dll => 0x17357fd5bfb48e14 => 14
	i64 1743969030606105336, ; 28: System.Memory.dll => 0x1833d297e88f2af8 => 46
	i64 1783757343580445821, ; 29: System.IdentityModel.dll => 0x18c12dda6d9b5c7d => 45
	i64 1795316252682057001, ; 30: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 61
	i64 1836611346387731153, ; 31: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 99
	i64 1865037103900624886, ; 32: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 10
	i64 1875917498431009007, ; 33: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 58
	i64 1981742497975770890, ; 34: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 87
	i64 2040001226662520565, ; 35: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 125
	i64 2117543737725979833, ; 36: Shed Shell  ListFlowers.Android.dll => 0x1d6306cf6b828cb9 => 0
	i64 2136356949452311481, ; 37: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 92
	i64 2165725771938924357, ; 38: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 65
	i64 2192948757939169934, ; 39: Microsoft.EntityFrameworkCore.Abstractions.dll => 0x1e6eeb46cf992a8e => 16
	i64 2262844636196693701, ; 40: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 76
	i64 2284400282711631002, ; 41: System.Web.Services => 0x1fb3d1f42fd4249a => 123
	i64 2287834202362508563, ; 42: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 4
	i64 2287887973817120656, ; 43: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 124
	i64 2329709569556905518, ; 44: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 84
	i64 2335503487726329082, ; 45: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 53
	i64 2337758774805907496, ; 46: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 50
	i64 2470498323731680442, ; 47: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 71
	i64 2479423007379663237, ; 48: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 104
	i64 2497223385847772520, ; 49: System.Runtime => 0x22a7eb7046413568 => 51
	i64 2547086958574651984, ; 50: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 57
	i64 2592350477072141967, ; 51: System.Xml.dll => 0x23f9e10627330e8f => 55
	i64 2624866290265602282, ; 52: mscorlib.dll => 0x246d65fbde2db8ea => 34
	i64 2656907746661064104, ; 53: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 27
	i64 2694427813909235223, ; 54: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 96
	i64 2783046991838674048, ; 55: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 50
	i64 2960931600190307745, ; 56: Xamarin.Forms.Core => 0x2917579a49927da1 => 110
	i64 3017704767998173186, ; 57: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 114
	i64 3289520064315143713, ; 58: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 83
	i64 3303437397778967116, ; 59: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 59
	i64 3311221304742556517, ; 60: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 49
	i64 3493805808809882663, ; 61: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 102
	i64 3494946837667399002, ; 62: Microsoft.Extensions.Configuration => 0x30808ba1c00a455a => 25
	i64 3522470458906976663, ; 63: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 101
	i64 3523004241079211829, ; 64: Microsoft.Extensions.Caching.Memory.dll => 0x30e439b10bb89735 => 22
	i64 3531994851595924923, ; 65: System.Numerics => 0x31042a9aade235bb => 48
	i64 3571415421602489686, ; 66: System.Runtime.dll => 0x319037675df7e556 => 51
	i64 3638003163729360188, ; 67: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 23
	i64 3655542548057982301, ; 68: Microsoft.Extensions.Configuration.dll => 0x32bb18945e52855d => 25
	i64 3716579019761409177, ; 69: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 70: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 98
	i64 3772598417116884899, ; 71: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 77
	i64 3869221888984012293, ; 72: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 30
	i64 3966267475168208030, ; 73: System.Memory => 0x370b03412596249e => 46
	i64 4337444564132831293, ; 74: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 36
	i64 4513320955448359355, ; 75: Microsoft.EntityFrameworkCore.Relational => 0x3ea2897f12d379bb => 18
	i64 4525561845656915374, ; 76: System.ServiceModel.Internals => 0x3ece06856b710dae => 131
	i64 4612482779465751747, ; 77: Microsoft.EntityFrameworkCore.Abstractions => 0x4002d4a662a99cc3 => 16
	i64 4636684751163556186, ; 78: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 106
	i64 4743821336939966868, ; 79: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 2
	i64 4782108999019072045, ; 80: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 64
	i64 4794310189461587505, ; 81: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 57
	i64 4795410492532947900, ; 82: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 101
	i64 5081566143765835342, ; 83: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 3
	i64 5099468265966638712, ; 84: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 3
	i64 5129462924058778861, ; 85: Microsoft.Data.Sqlite => 0x472f835a350f5ced => 14
	i64 5142919913060024034, ; 86: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 111
	i64 5203618020066742981, ; 87: Xamarin.Essentials => 0x4836f704f0e652c5 => 109
	i64 5205316157927637098, ; 88: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 90
	i64 5348796042099802469, ; 89: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 91
	i64 5376510917114486089, ; 90: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 104
	i64 5408338804355907810, ; 91: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 103
	i64 5446034149219586269, ; 92: System.Diagnostics.Debug => 0x4b94333452e150dd => 7
	i64 5451019430259338467, ; 93: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 70
	i64 5507995362134886206, ; 94: System.Core.dll => 0x4c705499688c873e => 42
	i64 5692067934154308417, ; 95: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 108
	i64 5757522595884336624, ; 96: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 68
	i64 5814345312393086621, ; 97: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 96
	i64 5896680224035167651, ; 98: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 85
	i64 6085203216496545422, ; 99: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 112
	i64 6086316965293125504, ; 100: FormsViewGroup.dll => 0x5476f10882baef80 => 8
	i64 6183170893902868313, ; 101: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 36
	i64 6222399776351216807, ; 102: System.Text.Json.dll => 0x565a67a0ffe264a7 => 54
	i64 6319713645133255417, ; 103: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 86
	i64 6401687960814735282, ; 104: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 84
	i64 6451641236149120789, ; 105: Shed Shell  ListFlowers.dll => 0x5988d585a2ee2f15 => 35
	i64 6504860066809920875, ; 106: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 65
	i64 6548213210057960872, ; 107: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 74
	i64 6560151584539558821, ; 108: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 31
	i64 6591024623626361694, ; 109: System.Web.Services.dll => 0x5b7805f9751a1b5e => 123
	i64 6659513131007730089, ; 110: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 80
	i64 6876862101832370452, ; 111: System.Xml.Linq => 0x5f6f85a57d108914 => 56
	i64 6894844156784520562, ; 112: System.Numerics.Vectors => 0x5faf683aead1ad72 => 49
	i64 7036436454368433159, ; 113: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 82
	i64 7103753931438454322, ; 114: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 79
	i64 7338192458477945005, ; 115: System.Reflection => 0x65d67f295d0740ad => 128
	i64 7473077275758116397, ; 116: Microsoft.DotNet.PlatformAbstractions => 0x67b5b430309b3e2d => 15
	i64 7488575175965059935, ; 117: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 56
	i64 7635363394907363464, ; 118: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 110
	i64 7637365915383206639, ; 119: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 109
	i64 7654504624184590948, ; 120: System.Net.Http => 0x6a3a4366801b8264 => 47
	i64 7735176074855944702, ; 121: Microsoft.CSharp => 0x6b58dda848e391fe => 12
	i64 7820441508502274321, ; 122: System.Data => 0x6c87ca1e14ff8111 => 116
	i64 7836164640616011524, ; 123: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 60
	i64 7972383140441761405, ; 124: Microsoft.Extensions.Caching.Abstractions.dll => 0x6ea3983a0b58267d => 21
	i64 8044118961405839122, ; 125: System.ComponentModel.Composition => 0x6fa2739369944712 => 122
	i64 8064050204834738623, ; 126: System.Collections.dll => 0x6fe942efa61731bf => 5
	i64 8083354569033831015, ; 127: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 83
	i64 8087206902342787202, ; 128: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 43
	i64 8103644804370223335, ; 129: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 118
	i64 8167236081217502503, ; 130: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 9
	i64 8185542183669246576, ; 131: System.Collections => 0x7198e33f4794aa70 => 5
	i64 8290740647658429042, ; 132: System.Runtime.Extensions => 0x730ea0b15c929a72 => 129
	i64 8318905602908530212, ; 133: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 124
	i64 8398329775253868912, ; 134: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 69
	i64 8400357532724379117, ; 135: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 95
	i64 8518412311883997971, ; 136: System.Collections.Immutable => 0x76377add7c28e313 => 41
	i64 8601935802264776013, ; 137: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 103
	i64 8626175481042262068, ; 138: Java.Interop => 0x77b654e585b55834 => 9
	i64 8638972117149407195, ; 139: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 12
	i64 8639588376636138208, ; 140: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 94
	i64 8684531736582871431, ; 141: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 121
	i64 8725526185868997716, ; 142: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 43
	i64 9111603110219107042, ; 143: Microsoft.Extensions.Caching.Memory => 0x7e72eac0def44ae2 => 22
	i64 9250544137016314866, ; 144: Microsoft.EntityFrameworkCore => 0x806088e191ee0bf2 => 17
	i64 9312692141327339315, ; 145: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 108
	i64 9324707631942237306, ; 146: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 61
	i64 9500688326720985260, ; 147: Microsoft.EntityFrameworkCore.SqlServer => 0x83d939b243e798ac => 20
	i64 9662334977499516867, ; 148: System.Numerics.dll => 0x8617827802b0cfc3 => 48
	i64 9678050649315576968, ; 149: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 71
	i64 9711637524876806384, ; 150: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 91
	i64 9808709177481450983, ; 151: Mono.Android.dll => 0x881f890734e555e7 => 33
	i64 9825649861376906464, ; 152: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 68
	i64 9834056768316610435, ; 153: System.Transactions.dll => 0x8879968718899783 => 117
	i64 9864956466380592553, ; 154: Microsoft.EntityFrameworkCore.Sqlite => 0x88e75da3af4ed5a9 => 19
	i64 9998632235833408227, ; 155: Mono.Security => 0x8ac2470b209ebae3 => 130
	i64 10038780035334861115, ; 156: System.Net.Http.dll => 0x8b50e941206af13b => 47
	i64 10205853378024263619, ; 157: Microsoft.Extensions.Configuration.Binder => 0x8da279930adb4fc3 => 24
	i64 10229024438826829339, ; 158: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 74
	i64 10376576884623852283, ; 159: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 102
	i64 10430153318873392755, ; 160: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 72
	i64 10447083246144586668, ; 161: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 10
	i64 10714184849103829812, ; 162: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 129
	i64 10811915265162633087, ; 163: Microsoft.EntityFrameworkCore.Relational.dll => 0x960ba3a651a45f7f => 18
	i64 10847732767863316357, ; 164: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 62
	i64 10889380495983713167, ; 165: Microsoft.Data.SqlClient.dll => 0x971ed9dddf2d1b8f => 13
	i64 10964653383833615866, ; 166: System.Diagnostics.Tracing => 0x982a4628ccaffdfa => 127
	i64 11002576679268595294, ; 167: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 29
	i64 11023048688141570732, ; 168: System.Core => 0x98f9bc61168392ac => 42
	i64 11037814507248023548, ; 169: System.Xml => 0x992e31d0412bf7fc => 55
	i64 11162124722117608902, ; 170: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 107
	i64 11226290749488709958, ; 171: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 31
	i64 11340910727871153756, ; 172: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 73
	i64 11392833485892708388, ; 173: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 97
	i64 11398376662953476300, ; 174: Microsoft.EntityFrameworkCore.Sqlite.dll => 0x9e2f2b2f0b71c0cc => 19
	i64 11485890710487134646, ; 175: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 126
	i64 11529969570048099689, ; 176: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 107
	i64 11530571088791430846, ; 177: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 30
	i64 11578238080964724296, ; 178: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 82
	i64 11580057168383206117, ; 179: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 58
	i64 11597940890313164233, ; 180: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 181: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 79
	i64 12102847907131387746, ; 182: System.Buffers => 0xa7f5f40c43256f62 => 40
	i64 12137774235383566651, ; 183: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 105
	i64 12145679461940342714, ; 184: System.Text.Json => 0xa88e1f1ebcb62fba => 54
	i64 12269460666702402136, ; 185: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 41
	i64 12279246230491828964, ; 186: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 39
	i64 12451044538927396471, ; 187: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 78
	i64 12466513435562512481, ; 188: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 89
	i64 12487638416075308985, ; 189: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 75
	i64 12493213219680520345, ; 190: Microsoft.Data.SqlClient => 0xad60cf3b3e458899 => 13
	i64 12538491095302438457, ; 191: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 66
	i64 12550732019250633519, ; 192: System.IO.Compression => 0xae2d28465e8e1b2f => 120
	i64 12700543734426720211, ; 193: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 67
	i64 12843321153144804894, ; 194: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 32
	i64 12963446364377008305, ; 195: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 119
	i64 13370592475155966277, ; 196: System.Runtime.Serialization => 0xb98de304062ea945 => 52
	i64 13401370062847626945, ; 197: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 105
	i64 13404347523447273790, ; 198: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 69
	i64 13454009404024712428, ; 199: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 115
	i64 13491513212026656886, ; 200: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 63
	i64 13572454107664307259, ; 201: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 98
	i64 13647894001087880694, ; 202: System.Data.dll => 0xbd670f48cb071df6 => 116
	i64 13818328264475132956, ; 203: Microsoft.Bcl.HashCode => 0xbfc4905809c7c41c => 11
	i64 13955418299340266673, ; 204: Microsoft.Extensions.DependencyModel.dll => 0xc1ab9b0118299cb1 => 28
	i64 13959074834287824816, ; 205: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 78
	i64 13967638549803255703, ; 206: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 111
	i64 14124974489674258913, ; 207: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 66
	i64 14125464355221830302, ; 208: System.Threading.dll => 0xc407bafdbc707a9e => 6
	i64 14133832980772275001, ; 209: Microsoft.EntityFrameworkCore.dll => 0xc425763635a1c339 => 17
	i64 14172845254133543601, ; 210: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 92
	i64 14261073672896646636, ; 211: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 97
	i64 14327695147300244862, ; 212: System.Reflection.dll => 0xc6d632d338eb4d7e => 128
	i64 14486659737292545672, ; 213: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 85
	i64 14551742072151931844, ; 214: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 53
	i64 14644440854989303794, ; 215: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 90
	i64 14669215534098758659, ; 216: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 27
	i64 14792063746108907174, ; 217: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 115
	i64 14852515768018889994, ; 218: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 73
	i64 14954917835170835695, ; 219: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 26
	i64 14987728460634540364, ; 220: System.IO.Compression.dll => 0xcfff1ba06622494c => 120
	i64 14988210264188246988, ; 221: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 75
	i64 15136253973786843953, ; 222: System.IdentityModel => 0xd20ec6cb39a8db31 => 45
	i64 15227001540531775957, ; 223: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 23
	i64 15370334346939861994, ; 224: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 72
	i64 15391712275433856905, ; 225: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 26
	i64 15582737692548360875, ; 226: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 88
	i64 15609085926864131306, ; 227: System.dll => 0xd89e9cf3334914ea => 44
	i64 15620595871140898079, ; 228: Microsoft.Extensions.DependencyModel => 0xd8c7812eef49651f => 28
	i64 15777549416145007739, ; 229: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 100
	i64 15810740023422282496, ; 230: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 113
	i64 15963349826457351533, ; 231: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 125
	i64 15972962360782274861, ; 232: Shed Shell  ListFlowers.Android => 0xddab5ca3851cc12d => 0
	i64 16154507427712707110, ; 233: System => 0xe03056ea4e39aa26 => 44
	i64 16321164108206115771, ; 234: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 29
	i64 16565028646146589191, ; 235: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 122
	i64 16621146507174665210, ; 236: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 70
	i64 16677317093839702854, ; 237: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 95
	i64 16755018182064898362, ; 238: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 37
	i64 16822611501064131242, ; 239: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 118
	i64 16833383113903931215, ; 240: mscorlib => 0xe99c30c1484d7f4f => 34
	i64 17024911836938395553, ; 241: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 59
	i64 17031351772568316411, ; 242: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 93
	i64 17037200463775726619, ; 243: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 81
	i64 17187273293601214786, ; 244: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 2
	i64 17333249706306540043, ; 245: System.Diagnostics.Tracing.dll => 0xf08c12c5bb8b920b => 127
	i64 17544493274320527064, ; 246: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 64
	i64 17685921127322830888, ; 247: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 7
	i64 17704177640604968747, ; 248: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 89
	i64 17710060891934109755, ; 249: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 87
	i64 17712670374920797664, ; 250: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 126
	i64 17838668724098252521, ; 251: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 40
	i64 17882897186074144999, ; 252: FormsViewGroup => 0xf82cd03e3ac830e7 => 8
	i64 17892495832318972303, ; 253: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 113
	i64 17928294245072900555, ; 254: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 121
	i64 18017743553296241350, ; 255: Microsoft.Extensions.Caching.Abstractions => 0xfa0be24cb44e92c6 => 21
	i64 18025913125965088385, ; 256: System.Threading => 0xfa28e87b91334681 => 6
	i64 18116111925905154859, ; 257: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 63
	i64 18121036031235206392, ; 258: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 93
	i64 18129453464017766560, ; 259: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 131
	i64 18245806341561545090, ; 260: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 4
	i64 18305135509493619199, ; 261: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 94
	i64 18370042311372477656, ; 262: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 38
	i64 18380184030268848184 ; 263: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 106
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [264 x i32] [
	i32 15, i32 77, i32 32, i32 33, i32 67, i32 99, i32 100, i32 35, ; 0..7
	i32 86, i32 24, i32 119, i32 80, i32 38, i32 76, i32 117, i32 112, ; 8..15
	i32 130, i32 11, i32 114, i32 20, i32 37, i32 62, i32 52, i32 39, ; 16..23
	i32 60, i32 88, i32 81, i32 14, i32 46, i32 45, i32 61, i32 99, ; 24..31
	i32 10, i32 58, i32 87, i32 125, i32 0, i32 92, i32 65, i32 16, ; 32..39
	i32 76, i32 123, i32 4, i32 124, i32 84, i32 53, i32 50, i32 71, ; 40..47
	i32 104, i32 51, i32 57, i32 55, i32 34, i32 27, i32 96, i32 50, ; 48..55
	i32 110, i32 114, i32 83, i32 59, i32 49, i32 102, i32 25, i32 101, ; 56..63
	i32 22, i32 48, i32 51, i32 23, i32 25, i32 1, i32 98, i32 77, ; 64..71
	i32 30, i32 46, i32 36, i32 18, i32 131, i32 16, i32 106, i32 2, ; 72..79
	i32 64, i32 57, i32 101, i32 3, i32 3, i32 14, i32 111, i32 109, ; 80..87
	i32 90, i32 91, i32 104, i32 103, i32 7, i32 70, i32 42, i32 108, ; 88..95
	i32 68, i32 96, i32 85, i32 112, i32 8, i32 36, i32 54, i32 86, ; 96..103
	i32 84, i32 35, i32 65, i32 74, i32 31, i32 123, i32 80, i32 56, ; 104..111
	i32 49, i32 82, i32 79, i32 128, i32 15, i32 56, i32 110, i32 109, ; 112..119
	i32 47, i32 12, i32 116, i32 60, i32 21, i32 122, i32 5, i32 83, ; 120..127
	i32 43, i32 118, i32 9, i32 5, i32 129, i32 124, i32 69, i32 95, ; 128..135
	i32 41, i32 103, i32 9, i32 12, i32 94, i32 121, i32 43, i32 22, ; 136..143
	i32 17, i32 108, i32 61, i32 20, i32 48, i32 71, i32 91, i32 33, ; 144..151
	i32 68, i32 117, i32 19, i32 130, i32 47, i32 24, i32 74, i32 102, ; 152..159
	i32 72, i32 10, i32 129, i32 18, i32 62, i32 13, i32 127, i32 29, ; 160..167
	i32 42, i32 55, i32 107, i32 31, i32 73, i32 97, i32 19, i32 126, ; 168..175
	i32 107, i32 30, i32 82, i32 58, i32 1, i32 79, i32 40, i32 105, ; 176..183
	i32 54, i32 41, i32 39, i32 78, i32 89, i32 75, i32 13, i32 66, ; 184..191
	i32 120, i32 67, i32 32, i32 119, i32 52, i32 105, i32 69, i32 115, ; 192..199
	i32 63, i32 98, i32 116, i32 11, i32 28, i32 78, i32 111, i32 66, ; 200..207
	i32 6, i32 17, i32 92, i32 97, i32 128, i32 85, i32 53, i32 90, ; 208..215
	i32 27, i32 115, i32 73, i32 26, i32 120, i32 75, i32 45, i32 23, ; 216..223
	i32 72, i32 26, i32 88, i32 44, i32 28, i32 100, i32 113, i32 125, ; 224..231
	i32 0, i32 44, i32 29, i32 122, i32 70, i32 95, i32 37, i32 118, ; 232..239
	i32 34, i32 59, i32 93, i32 81, i32 2, i32 127, i32 64, i32 7, ; 240..247
	i32 89, i32 87, i32 126, i32 40, i32 8, i32 113, i32 121, i32 21, ; 248..255
	i32 6, i32 63, i32 93, i32 131, i32 4, i32 94, i32 38, i32 106 ; 264..263
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
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
