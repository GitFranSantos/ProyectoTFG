; ModuleID = 'marshal_methods.armeabi-v7a.ll'
source_filename = "marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [156 x ptr] zeroinitializer, align 4

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [312 x i32] [
	i32 2616222, ; 0: System.Net.NetworkInformation.dll => 0x27eb9e => 114
	i32 10166715, ; 1: System.Net.NameResolution.dll => 0x9b21bb => 113
	i32 15721112, ; 2: System.Runtime.Intrinsics.dll => 0xefe298 => 131
	i32 42639949, ; 3: System.Threading.Thread => 0x28aa24d => 144
	i32 67008169, ; 4: zh-Hant\Microsoft.Maui.Controls.resources => 0x3fe76a9 => 33
	i32 68219467, ; 5: System.Security.Cryptography.Primitives => 0x410f24b => 137
	i32 72070932, ; 6: Microsoft.Maui.Graphics.dll => 0x44bb714 => 51
	i32 117431740, ; 7: System.Runtime.InteropServices => 0x6ffddbc => 130
	i32 122350210, ; 8: System.Threading.Channels.dll => 0x74aea82 => 142
	i32 142721839, ; 9: System.Net.WebHeaderCollection => 0x881c32f => 120
	i32 149972175, ; 10: System.Security.Cryptography.Primitives.dll => 0x8f064cf => 137
	i32 165246403, ; 11: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 62
	i32 182336117, ; 12: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 80
	i32 195452805, ; 13: vi/Microsoft.Maui.Controls.resources.dll => 0xba65f85 => 30
	i32 199333315, ; 14: zh-HK/Microsoft.Maui.Controls.resources.dll => 0xbe195c3 => 31
	i32 205061960, ; 15: System.ComponentModel => 0xc38ff48 => 96
	i32 212724149, ; 16: MongoDB.Driver.Core => 0xcade9b5 => 54
	i32 220171995, ; 17: System.Diagnostics.Debug => 0xd1f8edb => 98
	i32 276479776, ; 18: System.Threading.Timer.dll => 0x107abf20 => 145
	i32 280992041, ; 19: cs/Microsoft.Maui.Controls.resources.dll => 0x10bf9929 => 2
	i32 317674968, ; 20: vi\Microsoft.Maui.Controls.resources => 0x12ef55d8 => 30
	i32 318968648, ; 21: Xamarin.AndroidX.Activity.dll => 0x13031348 => 58
	i32 336156722, ; 22: ja/Microsoft.Maui.Controls.resources.dll => 0x14095832 => 15
	i32 342366114, ; 23: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 69
	i32 356389973, ; 24: it/Microsoft.Maui.Controls.resources.dll => 0x153e1455 => 14
	i32 367780167, ; 25: System.IO.Pipes => 0x15ebe147 => 107
	i32 375677976, ; 26: System.Net.ServicePoint.dll => 0x16646418 => 118
	i32 379916513, ; 27: System.Threading.Thread.dll => 0x16a510e1 => 144
	i32 385762202, ; 28: System.Memory.dll => 0x16fe439a => 111
	i32 395744057, ; 29: _Microsoft.Android.Resource.Designer => 0x17969339 => 34
	i32 435591531, ; 30: sv/Microsoft.Maui.Controls.resources.dll => 0x19f6996b => 26
	i32 442565967, ; 31: System.Collections => 0x1a61054f => 93
	i32 450948140, ; 32: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 68
	i32 469710990, ; 33: System.dll => 0x1bff388e => 150
	i32 498788369, ; 34: System.ObjectModel => 0x1dbae811 => 123
	i32 500358224, ; 35: id/Microsoft.Maui.Controls.resources.dll => 0x1dd2dc50 => 13
	i32 503918385, ; 36: fi/Microsoft.Maui.Controls.resources.dll => 0x1e092f31 => 7
	i32 513247710, ; 37: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 46
	i32 530272170, ; 38: System.Linq.Queryable => 0x1f9b4faa => 109
	i32 539058512, ; 39: Microsoft.Extensions.Logging => 0x20216150 => 43
	i32 540030774, ; 40: System.IO.FileSystem.dll => 0x20303736 => 106
	i32 545304856, ; 41: System.Runtime.Extensions => 0x2080b118 => 128
	i32 592146354, ; 42: pt-BR/Microsoft.Maui.Controls.resources.dll => 0x234b6fb2 => 21
	i32 613668793, ; 43: System.Security.Cryptography.Algorithms => 0x2493d7b9 => 136
	i32 627609679, ; 44: Xamarin.AndroidX.CustomView => 0x2568904f => 66
	i32 627931235, ; 45: nl\Microsoft.Maui.Controls.resources => 0x256d7863 => 19
	i32 672442732, ; 46: System.Collections.Concurrent => 0x2814a96c => 90
	i32 683518922, ; 47: System.Net.Security => 0x28bdabca => 117
	i32 688181140, ; 48: ca/Microsoft.Maui.Controls.resources.dll => 0x2904cf94 => 1
	i32 690569205, ; 49: System.Xml.Linq.dll => 0x29293ff5 => 147
	i32 706645707, ; 50: ko/Microsoft.Maui.Controls.resources.dll => 0x2a1e8ecb => 16
	i32 709557578, ; 51: de/Microsoft.Maui.Controls.resources.dll => 0x2a4afd4a => 4
	i32 722857257, ; 52: System.Runtime.Loader.dll => 0x2b15ed29 => 132
	i32 726425535, ; 53: MongoDB.Libmongocrypt.dll => 0x2b4c5fbf => 55
	i32 759454413, ; 54: System.Net.Requests => 0x2d445acd => 116
	i32 762598435, ; 55: System.IO.Pipes.dll => 0x2d745423 => 107
	i32 775507847, ; 56: System.IO.Compression => 0x2e394f87 => 105
	i32 777317022, ; 57: sk\Microsoft.Maui.Controls.resources => 0x2e54ea9e => 25
	i32 789151979, ; 58: Microsoft.Extensions.Options => 0x2f0980eb => 45
	i32 823281589, ; 59: System.Private.Uri.dll => 0x311247b5 => 124
	i32 830298997, ; 60: System.IO.Compression.Brotli => 0x317d5b75 => 104
	i32 904024072, ; 61: System.ComponentModel.Primitives.dll => 0x35e25008 => 94
	i32 926902833, ; 62: tr/Microsoft.Maui.Controls.resources.dll => 0x373f6a31 => 28
	i32 962901365, ; 63: MongoDB.Driver.Core.dll => 0x3964b575 => 54
	i32 967690846, ; 64: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 69
	i32 975874589, ; 65: System.Xml.XDocument => 0x3a2aaa1d => 149
	i32 992768348, ; 66: System.Collections.dll => 0x3b2c715c => 93
	i32 994442037, ; 67: System.IO.FileSystem => 0x3b45fb35 => 106
	i32 1012816738, ; 68: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 79
	i32 1028951442, ; 69: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 42
	i32 1029334545, ; 70: da/Microsoft.Maui.Controls.resources.dll => 0x3d5a6611 => 3
	i32 1035644815, ; 71: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 59
	i32 1044663988, ; 72: System.Linq.Expressions.dll => 0x3e444eb4 => 108
	i32 1052210849, ; 73: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 71
	i32 1082857460, ; 74: System.ComponentModel.TypeConverter => 0x408b17f4 => 95
	i32 1084122840, ; 75: Xamarin.Kotlin.StdLib => 0x409e66d8 => 84
	i32 1098259244, ; 76: System => 0x41761b2c => 150
	i32 1111289522, ; 77: DnsClient.dll => 0x423ceeb2 => 38
	i32 1118262833, ; 78: ko\Microsoft.Maui.Controls.resources => 0x42a75631 => 16
	i32 1168523401, ; 79: pt\Microsoft.Maui.Controls.resources => 0x45a64089 => 22
	i32 1178241025, ; 80: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 76
	i32 1186804405, ; 81: Incidenciapp.dll => 0x46bd32b5 => 87
	i32 1203215381, ; 82: pl/Microsoft.Maui.Controls.resources.dll => 0x47b79c15 => 20
	i32 1208641965, ; 83: System.Diagnostics.Process => 0x480a69ad => 100
	i32 1234928153, ; 84: nb/Microsoft.Maui.Controls.resources.dll => 0x499b8219 => 18
	i32 1253011324, ; 85: Microsoft.Win32.Registry => 0x4aaf6f7c => 89
	i32 1260983243, ; 86: cs\Microsoft.Maui.Controls.resources => 0x4b2913cb => 2
	i32 1293217323, ; 87: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 67
	i32 1324164729, ; 88: System.Linq => 0x4eed2679 => 110
	i32 1373134921, ; 89: zh-Hans\Microsoft.Maui.Controls.resources => 0x51d86049 => 32
	i32 1376866003, ; 90: Xamarin.AndroidX.SavedState => 0x52114ed3 => 79
	i32 1391893274, ; 91: MongoDB.Bson.dll => 0x52f69b1a => 52
	i32 1406073936, ; 92: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 63
	i32 1408764838, ; 93: System.Runtime.Serialization.Formatters.dll => 0x53f80ba6 => 134
	i32 1411638395, ; 94: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 127
	i32 1430672901, ; 95: ar\Microsoft.Maui.Controls.resources => 0x55465605 => 0
	i32 1452070440, ; 96: System.Formats.Asn1.dll => 0x568cd628 => 103
	i32 1457743152, ; 97: System.Runtime.Extensions.dll => 0x56e36530 => 128
	i32 1458022317, ; 98: System.Net.Security.dll => 0x56e7a7ad => 117
	i32 1461004990, ; 99: es\Microsoft.Maui.Controls.resources => 0x57152abe => 6
	i32 1462112819, ; 100: System.IO.Compression.dll => 0x57261233 => 105
	i32 1469204771, ; 101: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 60
	i32 1470490898, ; 102: Microsoft.Extensions.Primitives => 0x57a5e912 => 46
	i32 1480492111, ; 103: System.IO.Compression.Brotli.dll => 0x583e844f => 104
	i32 1487239319, ; 104: Microsoft.Win32.Primitives => 0x58a57897 => 88
	i32 1493001747, ; 105: hi/Microsoft.Maui.Controls.resources.dll => 0x58fd6613 => 10
	i32 1514721132, ; 106: el/Microsoft.Maui.Controls.resources.dll => 0x5a48cf6c => 5
	i32 1536373174, ; 107: System.Diagnostics.TextWriterTraceListener => 0x5b9331b6 => 101
	i32 1543031311, ; 108: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 141
	i32 1551623176, ; 109: sk/Microsoft.Maui.Controls.resources.dll => 0x5c7be408 => 25
	i32 1622152042, ; 110: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 73
	i32 1624863272, ; 111: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 82
	i32 1636350590, ; 112: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 65
	i32 1639515021, ; 113: System.Net.Http.dll => 0x61b9038d => 112
	i32 1639986890, ; 114: System.Text.RegularExpressions => 0x61c036ca => 141
	i32 1657153582, ; 115: System.Runtime => 0x62c6282e => 135
	i32 1658251792, ; 116: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 83
	i32 1670326403, ; 117: AWSSDK.Core.dll => 0x638f2883 => 35
	i32 1677501392, ; 118: System.Net.Primitives.dll => 0x63fca3d0 => 115
	i32 1679769178, ; 119: System.Security.Cryptography => 0x641f3e5a => 138
	i32 1701541528, ; 120: System.Diagnostics.Debug.dll => 0x656b7698 => 98
	i32 1729485958, ; 121: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 61
	i32 1736233607, ; 122: ro/Microsoft.Maui.Controls.resources.dll => 0x677cd287 => 23
	i32 1743415430, ; 123: ca\Microsoft.Maui.Controls.resources => 0x67ea6886 => 1
	i32 1750313021, ; 124: Microsoft.Win32.Primitives.dll => 0x6853a83d => 88
	i32 1763938596, ; 125: System.Diagnostics.TraceSource.dll => 0x69239124 => 102
	i32 1766324549, ; 126: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 80
	i32 1770582343, ; 127: Microsoft.Extensions.Logging.dll => 0x6988f147 => 43
	i32 1780572499, ; 128: Mono.Android.Runtime.dll => 0x6a216153 => 154
	i32 1782862114, ; 129: ms\Microsoft.Maui.Controls.resources => 0x6a445122 => 17
	i32 1788241197, ; 130: Xamarin.AndroidX.Fragment => 0x6a96652d => 68
	i32 1793755602, ; 131: he\Microsoft.Maui.Controls.resources => 0x6aea89d2 => 9
	i32 1800558761, ; 132: Incidenciapp => 0x6b5258a9 => 87
	i32 1807397336, ; 133: MongoDB.Driver => 0x6bbab1d8 => 53
	i32 1808609942, ; 134: Xamarin.AndroidX.Loader => 0x6bcd3296 => 73
	i32 1813058853, ; 135: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 84
	i32 1813201214, ; 136: Xamarin.Google.Android.Material => 0x6c13413e => 83
	i32 1818569960, ; 137: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 77
	i32 1824175904, ; 138: System.Text.Encoding.Extensions => 0x6cbab720 => 140
	i32 1824722060, ; 139: System.Runtime.Serialization.Formatters => 0x6cc30c8c => 134
	i32 1828688058, ; 140: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 44
	i32 1835989518, ; 141: Snappier => 0x6d6efa0e => 57
	i32 1842015223, ; 142: uk/Microsoft.Maui.Controls.resources.dll => 0x6dcaebf7 => 29
	i32 1853025655, ; 143: sv\Microsoft.Maui.Controls.resources => 0x6e72ed77 => 26
	i32 1858542181, ; 144: System.Linq.Expressions => 0x6ec71a65 => 108
	i32 1875935024, ; 145: fr\Microsoft.Maui.Controls.resources => 0x6fd07f30 => 8
	i32 1910275211, ; 146: System.Collections.NonGeneric.dll => 0x71dc7c8b => 91
	i32 1939592360, ; 147: System.Private.Xml.Linq => 0x739bd4a8 => 125
	i32 1968388702, ; 148: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 39
	i32 1988094259, ; 149: AWSSDK.SecurityToken.dll => 0x767fe933 => 36
	i32 2003115576, ; 150: el\Microsoft.Maui.Controls.resources => 0x77651e38 => 5
	i32 2019465201, ; 151: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 71
	i32 2025202353, ; 152: ar/Microsoft.Maui.Controls.resources.dll => 0x78b622b1 => 0
	i32 2045470958, ; 153: System.Private.Xml => 0x79eb68ee => 126
	i32 2055257422, ; 154: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 70
	i32 2066184531, ; 155: de\Microsoft.Maui.Controls.resources => 0x7b277953 => 4
	i32 2070888862, ; 156: System.Diagnostics.TraceSource => 0x7b6f419e => 102
	i32 2079903147, ; 157: System.Runtime.dll => 0x7bf8cdab => 135
	i32 2090596640, ; 158: System.Numerics.Vectors => 0x7c9bf920 => 122
	i32 2127167465, ; 159: System.Console => 0x7ec9ffe9 => 97
	i32 2142473426, ; 160: System.Collections.Specialized => 0x7fb38cd2 => 92
	i32 2159891885, ; 161: Microsoft.Maui => 0x80bd55ad => 49
	i32 2169148018, ; 162: hu\Microsoft.Maui.Controls.resources => 0x814a9272 => 12
	i32 2181898931, ; 163: Microsoft.Extensions.Options.dll => 0x820d22b3 => 45
	i32 2192057212, ; 164: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 44
	i32 2193016926, ; 165: System.ObjectModel.dll => 0x82b6c85e => 123
	i32 2201107256, ; 166: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 85
	i32 2201231467, ; 167: System.Net.Http => 0x8334206b => 112
	i32 2207618523, ; 168: it\Microsoft.Maui.Controls.resources => 0x839595db => 14
	i32 2266799131, ; 169: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 40
	i32 2270573516, ; 170: fr/Microsoft.Maui.Controls.resources.dll => 0x875633cc => 8
	i32 2279755925, ; 171: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 78
	i32 2290594010, ; 172: SharpCompress.dll => 0x8887b0da => 56
	i32 2295906218, ; 173: System.Net.Sockets => 0x88d8bfaa => 119
	i32 2303942373, ; 174: nb\Microsoft.Maui.Controls.resources => 0x89535ee5 => 18
	i32 2305521784, ; 175: System.Private.CoreLib.dll => 0x896b7878 => 152
	i32 2340441535, ; 176: System.Runtime.InteropServices.RuntimeInformation.dll => 0x8b804dbf => 129
	i32 2353062107, ; 177: System.Net.Primitives => 0x8c40e0db => 115
	i32 2368005991, ; 178: System.Xml.ReaderWriter.dll => 0x8d24e767 => 148
	i32 2371007202, ; 179: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 39
	i32 2395872292, ; 180: id\Microsoft.Maui.Controls.resources => 0x8ece1c24 => 13
	i32 2427813419, ; 181: hi\Microsoft.Maui.Controls.resources => 0x90b57e2b => 10
	i32 2435356389, ; 182: System.Console.dll => 0x912896e5 => 97
	i32 2458678730, ; 183: System.Net.Sockets.dll => 0x928c75ca => 119
	i32 2471841756, ; 184: netstandard.dll => 0x93554fdc => 151
	i32 2475788418, ; 185: Java.Interop.dll => 0x93918882 => 153
	i32 2480646305, ; 186: Microsoft.Maui.Controls => 0x93dba8a1 => 47
	i32 2484371297, ; 187: System.Net.ServicePoint => 0x94147f61 => 118
	i32 2550873716, ; 188: hr\Microsoft.Maui.Controls.resources => 0x980b3e74 => 11
	i32 2585220780, ; 189: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 140
	i32 2593496499, ; 190: pl\Microsoft.Maui.Controls.resources => 0x9a959db3 => 20
	i32 2605712449, ; 191: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 85
	i32 2611359322, ; 192: ZstdSharp.dll => 0x9ba62e5a => 86
	i32 2617129537, ; 193: System.Private.Xml.dll => 0x9bfe3a41 => 126
	i32 2620871830, ; 194: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 65
	i32 2626831493, ; 195: ja\Microsoft.Maui.Controls.resources => 0x9c924485 => 15
	i32 2627185994, ; 196: System.Diagnostics.TextWriterTraceListener.dll => 0x9c97ad4a => 101
	i32 2663698177, ; 197: System.Runtime.Loader => 0x9ec4cf01 => 132
	i32 2664396074, ; 198: System.Xml.XDocument.dll => 0x9ecf752a => 149
	i32 2715334215, ; 199: System.Threading.Tasks.dll => 0xa1d8b647 => 143
	i32 2724373263, ; 200: System.Runtime.Numerics.dll => 0xa262a30f => 133
	i32 2725980451, ; 201: SharpCompress => 0xa27b2923 => 56
	i32 2728513968, ; 202: MongoDB.Libmongocrypt => 0xa2a1d1b0 => 55
	i32 2732626843, ; 203: Xamarin.AndroidX.Activity => 0xa2e0939b => 58
	i32 2735172069, ; 204: System.Threading.Channels => 0xa30769e5 => 142
	i32 2737747696, ; 205: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 60
	i32 2752995522, ; 206: pt-BR\Microsoft.Maui.Controls.resources => 0xa41760c2 => 21
	i32 2758225723, ; 207: Microsoft.Maui.Controls.Xaml => 0xa4672f3b => 48
	i32 2764765095, ; 208: Microsoft.Maui.dll => 0xa4caf7a7 => 49
	i32 2765824710, ; 209: System.Text.Encoding.CodePages.dll => 0xa4db22c6 => 139
	i32 2778768386, ; 210: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 81
	i32 2785988530, ; 211: th\Microsoft.Maui.Controls.resources => 0xa60ecfb2 => 27
	i32 2801831435, ; 212: Microsoft.Maui.Graphics => 0xa7008e0b => 51
	i32 2806116107, ; 213: es/Microsoft.Maui.Controls.resources.dll => 0xa741ef0b => 6
	i32 2810250172, ; 214: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 63
	i32 2831556043, ; 215: nl/Microsoft.Maui.Controls.resources.dll => 0xa8c61dcb => 19
	i32 2853208004, ; 216: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 81
	i32 2861189240, ; 217: Microsoft.Maui.Essentials => 0xaa8a4878 => 50
	i32 2909740682, ; 218: System.Private.CoreLib => 0xad6f1e8a => 152
	i32 2916838712, ; 219: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 82
	i32 2919462931, ; 220: System.Numerics.Vectors.dll => 0xae037813 => 122
	i32 2959614098, ; 221: System.ComponentModel.dll => 0xb0682092 => 96
	i32 2970759306, ; 222: BCrypt.Net-Next.dll => 0xb112308a => 37
	i32 2972252294, ; 223: System.Security.Cryptography.Algorithms.dll => 0xb128f886 => 136
	i32 2978675010, ; 224: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 67
	i32 3038032645, ; 225: _Microsoft.Android.Resource.Designer.dll => 0xb514b305 => 34
	i32 3057625584, ; 226: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 74
	i32 3059408633, ; 227: Mono.Android.Runtime => 0xb65adef9 => 154
	i32 3059793426, ; 228: System.ComponentModel.Primitives => 0xb660be12 => 94
	i32 3075834255, ; 229: System.Threading.Tasks => 0xb755818f => 143
	i32 3077302341, ; 230: hu/Microsoft.Maui.Controls.resources.dll => 0xb76be845 => 12
	i32 3089219899, ; 231: ZstdSharp => 0xb821c13b => 86
	i32 3103600923, ; 232: System.Formats.Asn1 => 0xb8fd311b => 103
	i32 3143283668, ; 233: AWSSDK.SecurityToken => 0xbb5ab3d4 => 36
	i32 3173064269, ; 234: DnsClient => 0xbd211e4d => 38
	i32 3178803400, ; 235: Xamarin.AndroidX.Navigation.Fragment.dll => 0xbd78b0c8 => 75
	i32 3220365878, ; 236: System.Threading => 0xbff2e236 => 146
	i32 3252856589, ; 237: MongoDB.Driver.dll => 0xc1e2a70d => 53
	i32 3258312781, ; 238: Xamarin.AndroidX.CardView => 0xc235e84d => 61
	i32 3258876633, ; 239: MongoDB.Bson => 0xc23e82d9 => 52
	i32 3265493905, ; 240: System.Linq.Queryable.dll => 0xc2a37b91 => 109
	i32 3279906254, ; 241: Microsoft.Win32.Registry.dll => 0xc37f65ce => 89
	i32 3305363605, ; 242: fi\Microsoft.Maui.Controls.resources => 0xc503d895 => 7
	i32 3316684772, ; 243: System.Net.Requests.dll => 0xc5b097e4 => 116
	i32 3317135071, ; 244: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 66
	i32 3346324047, ; 245: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 76
	i32 3357674450, ; 246: ru\Microsoft.Maui.Controls.resources => 0xc8220bd2 => 24
	i32 3362522851, ; 247: Xamarin.AndroidX.Core => 0xc86c06e3 => 64
	i32 3366347497, ; 248: Java.Interop => 0xc8a662e9 => 153
	i32 3374999561, ; 249: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 78
	i32 3381016424, ; 250: da\Microsoft.Maui.Controls.resources => 0xc9863768 => 3
	i32 3395150330, ; 251: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 127
	i32 3428513518, ; 252: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 41
	i32 3430777524, ; 253: netstandard => 0xcc7d82b4 => 151
	i32 3457240403, ; 254: AWSSDK.Core => 0xce114d53 => 35
	i32 3463511458, ; 255: hr/Microsoft.Maui.Controls.resources.dll => 0xce70fda2 => 11
	i32 3471940407, ; 256: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 95
	i32 3472012038, ; 257: BCrypt.Net-Next => 0xcef2b306 => 37
	i32 3476120550, ; 258: Mono.Android => 0xcf3163e6 => 155
	i32 3479583265, ; 259: ru/Microsoft.Maui.Controls.resources.dll => 0xcf663a21 => 24
	i32 3484440000, ; 260: ro\Microsoft.Maui.Controls.resources => 0xcfb055c0 => 23
	i32 3509114376, ; 261: System.Xml.Linq => 0xd128d608 => 147
	i32 3560100363, ; 262: System.Threading.Timer => 0xd432d20b => 145
	i32 3580758918, ; 263: zh-HK\Microsoft.Maui.Controls.resources => 0xd56e0b86 => 31
	i32 3608519521, ; 264: System.Linq.dll => 0xd715a361 => 110
	i32 3624195450, ; 265: System.Runtime.InteropServices.RuntimeInformation => 0xd804d57a => 129
	i32 3641597786, ; 266: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 70
	i32 3643446276, ; 267: tr\Microsoft.Maui.Controls.resources => 0xd92a9404 => 28
	i32 3643854240, ; 268: Xamarin.AndroidX.Navigation.Fragment => 0xd930cda0 => 75
	i32 3657292374, ; 269: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 40
	i32 3660523487, ; 270: System.Net.NetworkInformation => 0xda2f27df => 114
	i32 3672681054, ; 271: Mono.Android.dll => 0xdae8aa5e => 155
	i32 3697841164, ; 272: zh-Hant/Microsoft.Maui.Controls.resources.dll => 0xdc68940c => 33
	i32 3700866549, ; 273: System.Net.WebProxy.dll => 0xdc96bdf5 => 121
	i32 3716563718, ; 274: System.Runtime.Intrinsics => 0xdd864306 => 131
	i32 3724971120, ; 275: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 74
	i32 3732100267, ; 276: System.Net.NameResolution => 0xde7354ab => 113
	i32 3748608112, ; 277: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 99
	i32 3786282454, ; 278: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 62
	i32 3791210109, ; 279: Snappier.dll => 0xe1f9467d => 57
	i32 3792276235, ; 280: System.Collections.NonGeneric => 0xe2098b0b => 91
	i32 3802395368, ; 281: System.Collections.Specialized.dll => 0xe2a3f2e8 => 92
	i32 3819260425, ; 282: System.Net.WebProxy => 0xe3a54a09 => 121
	i32 3823082795, ; 283: System.Security.Cryptography.dll => 0xe3df9d2b => 138
	i32 3841636137, ; 284: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 42
	i32 3849253459, ; 285: System.Runtime.InteropServices.dll => 0xe56ef253 => 130
	i32 3885497537, ; 286: System.Net.WebHeaderCollection.dll => 0xe797fcc1 => 120
	i32 3889960447, ; 287: zh-Hans/Microsoft.Maui.Controls.resources.dll => 0xe7dc15ff => 32
	i32 3896106733, ; 288: System.Collections.Concurrent.dll => 0xe839deed => 90
	i32 3896760992, ; 289: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 64
	i32 3928044579, ; 290: System.Xml.ReaderWriter => 0xea213423 => 148
	i32 3931092270, ; 291: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 77
	i32 3953953790, ; 292: System.Text.Encoding.CodePages => 0xebac8bfe => 139
	i32 3955647286, ; 293: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 59
	i32 3980434154, ; 294: th/Microsoft.Maui.Controls.resources.dll => 0xed409aea => 27
	i32 3987592930, ; 295: he/Microsoft.Maui.Controls.resources.dll => 0xedadd6e2 => 9
	i32 4003436829, ; 296: System.Diagnostics.Process.dll => 0xee9f991d => 100
	i32 4025784931, ; 297: System.Memory => 0xeff49a63 => 111
	i32 4046471985, ; 298: Microsoft.Maui.Controls.Xaml.dll => 0xf1304331 => 48
	i32 4068434129, ; 299: System.Private.Xml.Linq.dll => 0xf27f60d1 => 125
	i32 4073602200, ; 300: System.Threading.dll => 0xf2ce3c98 => 146
	i32 4094352644, ; 301: Microsoft.Maui.Essentials.dll => 0xf40add04 => 50
	i32 4100113165, ; 302: System.Private.Uri => 0xf462c30d => 124
	i32 4102112229, ; 303: pt/Microsoft.Maui.Controls.resources.dll => 0xf48143e5 => 22
	i32 4125707920, ; 304: ms/Microsoft.Maui.Controls.resources.dll => 0xf5e94e90 => 17
	i32 4126470640, ; 305: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 41
	i32 4150914736, ; 306: uk\Microsoft.Maui.Controls.resources => 0xf769eeb0 => 29
	i32 4182413190, ; 307: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 72
	i32 4213026141, ; 308: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 99
	i32 4271975918, ; 309: Microsoft.Maui.Controls.dll => 0xfea12dee => 47
	i32 4274976490, ; 310: System.Runtime.Numerics => 0xfecef6ea => 133
	i32 4292120959 ; 311: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 72
], align 4

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [312 x i32] [
	i32 114, ; 0
	i32 113, ; 1
	i32 131, ; 2
	i32 144, ; 3
	i32 33, ; 4
	i32 137, ; 5
	i32 51, ; 6
	i32 130, ; 7
	i32 142, ; 8
	i32 120, ; 9
	i32 137, ; 10
	i32 62, ; 11
	i32 80, ; 12
	i32 30, ; 13
	i32 31, ; 14
	i32 96, ; 15
	i32 54, ; 16
	i32 98, ; 17
	i32 145, ; 18
	i32 2, ; 19
	i32 30, ; 20
	i32 58, ; 21
	i32 15, ; 22
	i32 69, ; 23
	i32 14, ; 24
	i32 107, ; 25
	i32 118, ; 26
	i32 144, ; 27
	i32 111, ; 28
	i32 34, ; 29
	i32 26, ; 30
	i32 93, ; 31
	i32 68, ; 32
	i32 150, ; 33
	i32 123, ; 34
	i32 13, ; 35
	i32 7, ; 36
	i32 46, ; 37
	i32 109, ; 38
	i32 43, ; 39
	i32 106, ; 40
	i32 128, ; 41
	i32 21, ; 42
	i32 136, ; 43
	i32 66, ; 44
	i32 19, ; 45
	i32 90, ; 46
	i32 117, ; 47
	i32 1, ; 48
	i32 147, ; 49
	i32 16, ; 50
	i32 4, ; 51
	i32 132, ; 52
	i32 55, ; 53
	i32 116, ; 54
	i32 107, ; 55
	i32 105, ; 56
	i32 25, ; 57
	i32 45, ; 58
	i32 124, ; 59
	i32 104, ; 60
	i32 94, ; 61
	i32 28, ; 62
	i32 54, ; 63
	i32 69, ; 64
	i32 149, ; 65
	i32 93, ; 66
	i32 106, ; 67
	i32 79, ; 68
	i32 42, ; 69
	i32 3, ; 70
	i32 59, ; 71
	i32 108, ; 72
	i32 71, ; 73
	i32 95, ; 74
	i32 84, ; 75
	i32 150, ; 76
	i32 38, ; 77
	i32 16, ; 78
	i32 22, ; 79
	i32 76, ; 80
	i32 87, ; 81
	i32 20, ; 82
	i32 100, ; 83
	i32 18, ; 84
	i32 89, ; 85
	i32 2, ; 86
	i32 67, ; 87
	i32 110, ; 88
	i32 32, ; 89
	i32 79, ; 90
	i32 52, ; 91
	i32 63, ; 92
	i32 134, ; 93
	i32 127, ; 94
	i32 0, ; 95
	i32 103, ; 96
	i32 128, ; 97
	i32 117, ; 98
	i32 6, ; 99
	i32 105, ; 100
	i32 60, ; 101
	i32 46, ; 102
	i32 104, ; 103
	i32 88, ; 104
	i32 10, ; 105
	i32 5, ; 106
	i32 101, ; 107
	i32 141, ; 108
	i32 25, ; 109
	i32 73, ; 110
	i32 82, ; 111
	i32 65, ; 112
	i32 112, ; 113
	i32 141, ; 114
	i32 135, ; 115
	i32 83, ; 116
	i32 35, ; 117
	i32 115, ; 118
	i32 138, ; 119
	i32 98, ; 120
	i32 61, ; 121
	i32 23, ; 122
	i32 1, ; 123
	i32 88, ; 124
	i32 102, ; 125
	i32 80, ; 126
	i32 43, ; 127
	i32 154, ; 128
	i32 17, ; 129
	i32 68, ; 130
	i32 9, ; 131
	i32 87, ; 132
	i32 53, ; 133
	i32 73, ; 134
	i32 84, ; 135
	i32 83, ; 136
	i32 77, ; 137
	i32 140, ; 138
	i32 134, ; 139
	i32 44, ; 140
	i32 57, ; 141
	i32 29, ; 142
	i32 26, ; 143
	i32 108, ; 144
	i32 8, ; 145
	i32 91, ; 146
	i32 125, ; 147
	i32 39, ; 148
	i32 36, ; 149
	i32 5, ; 150
	i32 71, ; 151
	i32 0, ; 152
	i32 126, ; 153
	i32 70, ; 154
	i32 4, ; 155
	i32 102, ; 156
	i32 135, ; 157
	i32 122, ; 158
	i32 97, ; 159
	i32 92, ; 160
	i32 49, ; 161
	i32 12, ; 162
	i32 45, ; 163
	i32 44, ; 164
	i32 123, ; 165
	i32 85, ; 166
	i32 112, ; 167
	i32 14, ; 168
	i32 40, ; 169
	i32 8, ; 170
	i32 78, ; 171
	i32 56, ; 172
	i32 119, ; 173
	i32 18, ; 174
	i32 152, ; 175
	i32 129, ; 176
	i32 115, ; 177
	i32 148, ; 178
	i32 39, ; 179
	i32 13, ; 180
	i32 10, ; 181
	i32 97, ; 182
	i32 119, ; 183
	i32 151, ; 184
	i32 153, ; 185
	i32 47, ; 186
	i32 118, ; 187
	i32 11, ; 188
	i32 140, ; 189
	i32 20, ; 190
	i32 85, ; 191
	i32 86, ; 192
	i32 126, ; 193
	i32 65, ; 194
	i32 15, ; 195
	i32 101, ; 196
	i32 132, ; 197
	i32 149, ; 198
	i32 143, ; 199
	i32 133, ; 200
	i32 56, ; 201
	i32 55, ; 202
	i32 58, ; 203
	i32 142, ; 204
	i32 60, ; 205
	i32 21, ; 206
	i32 48, ; 207
	i32 49, ; 208
	i32 139, ; 209
	i32 81, ; 210
	i32 27, ; 211
	i32 51, ; 212
	i32 6, ; 213
	i32 63, ; 214
	i32 19, ; 215
	i32 81, ; 216
	i32 50, ; 217
	i32 152, ; 218
	i32 82, ; 219
	i32 122, ; 220
	i32 96, ; 221
	i32 37, ; 222
	i32 136, ; 223
	i32 67, ; 224
	i32 34, ; 225
	i32 74, ; 226
	i32 154, ; 227
	i32 94, ; 228
	i32 143, ; 229
	i32 12, ; 230
	i32 86, ; 231
	i32 103, ; 232
	i32 36, ; 233
	i32 38, ; 234
	i32 75, ; 235
	i32 146, ; 236
	i32 53, ; 237
	i32 61, ; 238
	i32 52, ; 239
	i32 109, ; 240
	i32 89, ; 241
	i32 7, ; 242
	i32 116, ; 243
	i32 66, ; 244
	i32 76, ; 245
	i32 24, ; 246
	i32 64, ; 247
	i32 153, ; 248
	i32 78, ; 249
	i32 3, ; 250
	i32 127, ; 251
	i32 41, ; 252
	i32 151, ; 253
	i32 35, ; 254
	i32 11, ; 255
	i32 95, ; 256
	i32 37, ; 257
	i32 155, ; 258
	i32 24, ; 259
	i32 23, ; 260
	i32 147, ; 261
	i32 145, ; 262
	i32 31, ; 263
	i32 110, ; 264
	i32 129, ; 265
	i32 70, ; 266
	i32 28, ; 267
	i32 75, ; 268
	i32 40, ; 269
	i32 114, ; 270
	i32 155, ; 271
	i32 33, ; 272
	i32 121, ; 273
	i32 131, ; 274
	i32 74, ; 275
	i32 113, ; 276
	i32 99, ; 277
	i32 62, ; 278
	i32 57, ; 279
	i32 91, ; 280
	i32 92, ; 281
	i32 121, ; 282
	i32 138, ; 283
	i32 42, ; 284
	i32 130, ; 285
	i32 120, ; 286
	i32 32, ; 287
	i32 90, ; 288
	i32 64, ; 289
	i32 148, ; 290
	i32 77, ; 291
	i32 139, ; 292
	i32 59, ; 293
	i32 27, ; 294
	i32 9, ; 295
	i32 100, ; 296
	i32 111, ; 297
	i32 48, ; 298
	i32 125, ; 299
	i32 146, ; 300
	i32 50, ; 301
	i32 124, ; 302
	i32 22, ; 303
	i32 17, ; 304
	i32 41, ; 305
	i32 29, ; 306
	i32 72, ; 307
	i32 99, ; 308
	i32 47, ; 309
	i32 133, ; 310
	i32 72 ; 311
], align 4

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 4

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 4

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 4

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 4, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 1

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }

; Metadata
!llvm.module.flags = !{!0, !1, !7}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.2xx @ 0d97e20b84d8e87c3502469ee395805907905fe3"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"min_enum_size", i32 4}
