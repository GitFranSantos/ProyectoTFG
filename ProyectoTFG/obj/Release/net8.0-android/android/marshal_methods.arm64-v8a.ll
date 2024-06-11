; ModuleID = 'marshal_methods.arm64-v8a.ll'
source_filename = "marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [156 x ptr] zeroinitializer, align 8

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [312 x i64] [
	i64 98382396393917666, ; 0: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 46
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 155
	i64 131669012237370309, ; 2: Microsoft.Maui.Essentials.dll => 0x1d3c844de55c3c5 => 50
	i64 196720943101637631, ; 3: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 108
	i64 210515253464952879, ; 4: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 62
	i64 232391251801502327, ; 5: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 79
	i64 486223428996552534, ; 6: ZstdSharp.dll => 0x6bf69a1eecfd756 => 86
	i64 545109961164950392, ; 7: fi/Microsoft.Maui.Controls.resources.dll => 0x7909e9f1ec38b78 => 7
	i64 750875890346172408, ; 8: System.Threading.Thread => 0xa6ba5a4da7d1ff8 => 144
	i64 799765834175365804, ; 9: System.ComponentModel.dll => 0xb1956c9f18442ac => 96
	i64 849051935479314978, ; 10: hi/Microsoft.Maui.Controls.resources.dll => 0xbc8703ca21a3a22 => 10
	i64 872800313462103108, ; 11: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 67
	i64 1120440138749646132, ; 12: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 83
	i64 1121665720830085036, ; 13: nb/Microsoft.Maui.Controls.resources.dll => 0xf90f507becf47ac => 18
	i64 1369545283391376210, ; 14: Xamarin.AndroidX.Navigation.Fragment.dll => 0x13019a2dd85acb52 => 75
	i64 1476839205573959279, ; 15: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 115
	i64 1486715745332614827, ; 16: Microsoft.Maui.Controls.dll => 0x14a1e017ea87d6ab => 47
	i64 1513467482682125403, ; 17: Mono.Android.Runtime => 0x1500eaa8245f6c5b => 154
	i64 1537168428375924959, ; 18: System.Threading.Thread.dll => 0x15551e8a954ae0df => 144
	i64 1556147632182429976, ; 19: ko/Microsoft.Maui.Controls.resources.dll => 0x15988c06d24c8918 => 16
	i64 1559087064654078745, ; 20: BCrypt.Net-Next.dll => 0x15a2fd6cc69ce319 => 37
	i64 1624659445732251991, ; 21: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 60
	i64 1628611045998245443, ; 22: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 72
	i64 1743969030606105336, ; 23: System.Memory.dll => 0x1833d297e88f2af8 => 111
	i64 1767386781656293639, ; 24: System.Private.Uri.dll => 0x188704e9f5582107 => 124
	i64 1795316252682057001, ; 25: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 59
	i64 1825687700144851180, ; 26: System.Runtime.InteropServices.RuntimeInformation.dll => 0x1956254a55ef08ec => 129
	i64 1835311033149317475, ; 27: es\Microsoft.Maui.Controls.resources => 0x197855a927386163 => 6
	i64 1836611346387731153, ; 28: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 79
	i64 1881198190668717030, ; 29: tr\Microsoft.Maui.Controls.resources => 0x1a1b5bc992ea9be6 => 28
	i64 1920760634179481754, ; 30: Microsoft.Maui.Controls.Xaml => 0x1aa7e99ec2d2709a => 48
	i64 1959996714666907089, ; 31: tr/Microsoft.Maui.Controls.resources.dll => 0x1b334ea0a2a755d1 => 28
	i64 1972385128188460614, ; 32: System.Security.Cryptography.Algorithms => 0x1b5f51d2edefbe46 => 136
	i64 1981742497975770890, ; 33: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 71
	i64 1983698669889758782, ; 34: cs/Microsoft.Maui.Controls.resources.dll => 0x1b87836e2031a63e => 2
	i64 2019660174692588140, ; 35: pl/Microsoft.Maui.Controls.resources.dll => 0x1c07463a6f8e1a6c => 20
	i64 2262844636196693701, ; 36: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 67
	i64 2287834202362508563, ; 37: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 90
	i64 2302323944321350744, ; 38: ru/Microsoft.Maui.Controls.resources.dll => 0x1ff37f6ddb267c58 => 24
	i64 2315304989185124968, ; 39: System.IO.FileSystem.dll => 0x20219d9ee311aa68 => 106
	i64 2329709569556905518, ; 40: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 70
	i64 2337758774805907496, ; 41: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 127
	i64 2443621855109524048, ; 42: AWSSDK.Core.dll => 0x21e97d215f2f2a50 => 35
	i64 2470498323731680442, ; 43: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 63
	i64 2497223385847772520, ; 44: System.Runtime => 0x22a7eb7046413568 => 135
	i64 2547086958574651984, ; 45: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 58
	i64 2602673633151553063, ; 46: th\Microsoft.Maui.Controls.resources => 0x241e8de13a460e27 => 27
	i64 2632269733008246987, ; 47: System.Net.NameResolution => 0x2487b36034f808cb => 113
	i64 2656907746661064104, ; 48: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 41
	i64 2662981627730767622, ; 49: cs\Microsoft.Maui.Controls.resources => 0x24f4cfae6c48af06 => 2
	i64 2783046991838674048, ; 50: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 127
	i64 2895129759130297543, ; 51: fi\Microsoft.Maui.Controls.resources => 0x282d912d479fa4c7 => 7
	i64 3017136373564924869, ; 52: System.Net.WebProxy => 0x29df058bd93f63c5 => 121
	i64 3017704767998173186, ; 53: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 83
	i64 3289520064315143713, ; 54: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 69
	i64 3311221304742556517, ; 55: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 122
	i64 3325875462027654285, ; 56: System.Runtime.Numerics => 0x2e27e21c8958b48d => 133
	i64 3328853167529574890, ; 57: System.Net.Sockets.dll => 0x2e327651a008c1ea => 119
	i64 3344514922410554693, ; 58: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 85
	i64 3429672777697402584, ; 59: Microsoft.Maui.Essentials => 0x2f98a5385a7b1ed8 => 50
	i64 3494946837667399002, ; 60: Microsoft.Extensions.Configuration => 0x30808ba1c00a455a => 39
	i64 3522470458906976663, ; 61: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 80
	i64 3551103847008531295, ; 62: System.Private.CoreLib.dll => 0x31480e226177735f => 152
	i64 3567343442040498961, ; 63: pt\Microsoft.Maui.Controls.resources => 0x3181bff5bea4ab11 => 22
	i64 3571415421602489686, ; 64: System.Runtime.dll => 0x319037675df7e556 => 135
	i64 3638003163729360188, ; 65: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 40
	i64 3647754201059316852, ; 66: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 148
	i64 3655542548057982301, ; 67: Microsoft.Extensions.Configuration.dll => 0x32bb18945e52855d => 39
	i64 3716579019761409177, ; 68: netstandard.dll => 0x3393f0ed5c8c5c99 => 151
	i64 3727469159507183293, ; 69: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 78
	i64 3869221888984012293, ; 70: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 43
	i64 3890352374528606784, ; 71: Microsoft.Maui.Controls.Xaml.dll => 0x35fd4edf66e00240 => 48
	i64 3933965368022646939, ; 72: System.Net.Requests => 0x369840a8bfadc09b => 116
	i64 3966267475168208030, ; 73: System.Memory => 0x370b03412596249e => 111
	i64 4073500526318903918, ; 74: System.Private.Xml.dll => 0x3887fb25779ae26e => 126
	i64 4120493066591692148, ; 75: zh-Hant\Microsoft.Maui.Controls.resources => 0x392eee9cdda86574 => 33
	i64 4154383907710350974, ; 76: System.ComponentModel => 0x39a7562737acb67e => 96
	i64 4184189618158325478, ; 77: MongoDB.Driver.dll => 0x3a113a49f7344ee6 => 53
	i64 4187479170553454871, ; 78: System.Linq.Expressions => 0x3a1cea1e912fa117 => 108
	i64 4205801962323029395, ; 79: System.ComponentModel.TypeConverter => 0x3a5e0299f7e7ad93 => 95
	i64 4356591372459378815, ; 80: vi/Microsoft.Maui.Controls.resources.dll => 0x3c75b8c562f9087f => 30
	i64 4373617458794931033, ; 81: System.IO.Pipes.dll => 0x3cb235e806eb2359 => 107
	i64 4679594760078841447, ; 82: ar/Microsoft.Maui.Controls.resources.dll => 0x40f142a407475667 => 0
	i64 4794310189461587505, ; 83: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 58
	i64 4795410492532947900, ; 84: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 80
	i64 4814660307502931973, ; 85: System.Net.NameResolution.dll => 0x42d11c0a5ee2a005 => 113
	i64 4853321196694829351, ; 86: System.Runtime.Loader.dll => 0x435a75ea15de7927 => 132
	i64 4926014167703849846, ; 87: MongoDB.Driver => 0x445cb7c950878b76 => 53
	i64 5103417709280584325, ; 88: System.Collections.Specialized => 0x46d2fb5e161b6285 => 92
	i64 5182934613077526976, ; 89: System.Collections.Specialized.dll => 0x47ed7b91fa9009c0 => 92
	i64 5290786973231294105, ; 90: System.Runtime.Loader => 0x496ca6b869b72699 => 132
	i64 5388159308784456503, ; 91: Snappier => 0x4ac69657f94fd337 => 57
	i64 5423376490970181369, ; 92: System.Runtime.InteropServices.RuntimeInformation => 0x4b43b42f2b7b6ef9 => 129
	i64 5446034149219586269, ; 93: System.Diagnostics.Debug => 0x4b94333452e150dd => 98
	i64 5448796023926118037, ; 94: MongoDB.Libmongocrypt.dll => 0x4b9e031d63ad5695 => 55
	i64 5471532531798518949, ; 95: sv\Microsoft.Maui.Controls.resources => 0x4beec9d926d82ca5 => 26
	i64 5522859530602327440, ; 96: uk\Microsoft.Maui.Controls.resources => 0x4ca5237b51eead90 => 29
	i64 5570799893513421663, ; 97: System.IO.Compression.Brotli => 0x4d4f74fcdfa6c35f => 104
	i64 5573260873512690141, ; 98: System.Security.Cryptography.dll => 0x4d58333c6e4ea1dd => 138
	i64 5650097808083101034, ; 99: System.Security.Cryptography.Algorithms.dll => 0x4e692e055d01a56a => 136
	i64 5692067934154308417, ; 100: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 82
	i64 5979151488806146654, ; 101: System.Formats.Asn1 => 0x52fa3699a489d25e => 103
	i64 5984759512290286505, ; 102: System.Security.Cryptography.Primitives => 0x530e23115c33dba9 => 137
	i64 6068057819846744445, ; 103: ro/Microsoft.Maui.Controls.resources.dll => 0x5436126fec7f197d => 23
	i64 6200764641006662125, ; 104: ro\Microsoft.Maui.Controls.resources => 0x560d8a96830131ed => 23
	i64 6357457916754632952, ; 105: _Microsoft.Android.Resource.Designer => 0x583a3a4ac2a7a0f8 => 34
	i64 6401687960814735282, ; 106: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 70
	i64 6476067149090213100, ; 107: SharpCompress => 0x59df9cc2ab194cec => 56
	i64 6478287442656530074, ; 108: hr\Microsoft.Maui.Controls.resources => 0x59e7801b0c6a8e9a => 11
	i64 6548213210057960872, ; 109: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 66
	i64 6560151584539558821, ; 110: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 45
	i64 6617685658146568858, ; 111: System.Text.Encoding.CodePages => 0x5bd6be0b4905fa9a => 139
	i64 6743165466166707109, ; 112: nl\Microsoft.Maui.Controls.resources => 0x5d948943c08c43a5 => 19
	i64 6777482997383978746, ; 113: pt/Microsoft.Maui.Controls.resources.dll => 0x5e0e74e0a2525efa => 22
	i64 6786606130239981554, ; 114: System.Diagnostics.TraceSource => 0x5e2ede51877147f2 => 102
	i64 6814185388980153342, ; 115: System.Xml.XDocument.dll => 0x5e90d98217d1abfe => 149
	i64 6876862101832370452, ; 116: System.Xml.Linq => 0x5f6f85a57d108914 => 147
	i64 6894844156784520562, ; 117: System.Numerics.Vectors => 0x5faf683aead1ad72 => 122
	i64 7083547580668757502, ; 118: System.Private.Xml.Linq.dll => 0x624dd0fe8f56c5fe => 125
	i64 7112547816752919026, ; 119: System.IO.FileSystem => 0x62b4d88e3189b1f2 => 106
	i64 7220009545223068405, ; 120: sv/Microsoft.Maui.Controls.resources.dll => 0x6432a06d99f35af5 => 26
	i64 7243049202045766964, ; 121: MongoDB.Bson.dll => 0x64847adfba9d4d34 => 52
	i64 7270811800166795866, ; 122: System.Linq => 0x64e71ccf51a90a5a => 110
	i64 7316205155833392065, ; 123: Microsoft.Win32.Primitives => 0x658861d38954abc1 => 88
	i64 7377312882064240630, ; 124: System.ComponentModel.TypeConverter.dll => 0x66617afac45a2ff6 => 95
	i64 7488575175965059935, ; 125: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 147
	i64 7489048572193775167, ; 126: System.ObjectModel => 0x67ee71ff6b419e3f => 123
	i64 7592577537120840276, ; 127: System.Diagnostics.Process => 0x695e410af5b2aa54 => 100
	i64 7654504624184590948, ; 128: System.Net.Http => 0x6a3a4366801b8264 => 112
	i64 7708790323521193081, ; 129: ms/Microsoft.Maui.Controls.resources.dll => 0x6afb1ff4d1730479 => 17
	i64 7714652370974252055, ; 130: System.Private.CoreLib => 0x6b0ff375198b9c17 => 152
	i64 7729023323672879921, ; 131: DnsClient.dll => 0x6b4301c3443b2331 => 38
	i64 7735352534559001595, ; 132: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 84
	i64 7836164640616011524, ; 133: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 60
	i64 8031450141206250471, ; 134: System.Runtime.Intrinsics.dll => 0x6f757159d9dc03e7 => 131
	i64 8064050204834738623, ; 135: System.Collections.dll => 0x6fe942efa61731bf => 93
	i64 8083354569033831015, ; 136: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 69
	i64 8087206902342787202, ; 137: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 99
	i64 8167236081217502503, ; 138: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 153
	i64 8185542183669246576, ; 139: System.Collections => 0x7198e33f4794aa70 => 93
	i64 8246048515196606205, ; 140: Microsoft.Maui.Graphics.dll => 0x726fd96f64ee56fd => 51
	i64 8264926008854159966, ; 141: System.Diagnostics.Process.dll => 0x72b2ea6a64a3a25e => 100
	i64 8290740647658429042, ; 142: System.Runtime.Extensions => 0x730ea0b15c929a72 => 128
	i64 8308610922448049511, ; 143: MongoDB.Bson => 0x734e1d9cf1725567 => 52
	i64 8368701292315763008, ; 144: System.Security.Cryptography => 0x7423997c6fd56140 => 138
	i64 8400357532724379117, ; 145: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 77
	i64 8476828615142258695, ; 146: BCrypt.Net-Next => 0x75a3beb69b6bb807 => 37
	i64 8563666267364444763, ; 147: System.Private.Uri => 0x76d841191140ca5b => 124
	i64 8614108721271900878, ; 148: pt-BR/Microsoft.Maui.Controls.resources.dll => 0x778b763e14018ace => 21
	i64 8626175481042262068, ; 149: Java.Interop => 0x77b654e585b55834 => 153
	i64 8639588376636138208, ; 150: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 76
	i64 8648495978913578441, ; 151: Microsoft.Win32.Registry.dll => 0x7805a1456889bdc9 => 89
	i64 8677882282824630478, ; 152: pt-BR\Microsoft.Maui.Controls.resources => 0x786e07f5766b00ce => 21
	i64 8725526185868997716, ; 153: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 99
	i64 8941376889969657626, ; 154: System.Xml.XDocument => 0x7c1626e87187471a => 149
	i64 9045785047181495996, ; 155: zh-HK\Microsoft.Maui.Controls.resources => 0x7d891592e3cb0ebc => 31
	i64 9312692141327339315, ; 156: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 82
	i64 9324707631942237306, ; 157: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 59
	i64 9461546124022044683, ; 158: AWSSDK.Core => 0x834e2a12044ed80b => 35
	i64 9659729154652888475, ; 159: System.Text.RegularExpressions => 0x860e407c9991dd9b => 141
	i64 9678050649315576968, ; 160: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 63
	i64 9702891218465930390, ; 161: System.Collections.NonGeneric.dll => 0x86a79827b2eb3c96 => 91
	i64 9808709177481450983, ; 162: Mono.Android.dll => 0x881f890734e555e7 => 155
	i64 9933555792566666578, ; 163: System.Linq.Queryable.dll => 0x89db145cf475c552 => 109
	i64 9956195530459977388, ; 164: Microsoft.Maui => 0x8a2b8315b36616ac => 49
	i64 9991543690424095600, ; 165: es/Microsoft.Maui.Controls.resources.dll => 0x8aa9180c89861370 => 6
	i64 10038780035334861115, ; 166: System.Net.Http.dll => 0x8b50e941206af13b => 112
	i64 10051358222726253779, ; 167: System.Private.Xml => 0x8b7d990c97ccccd3 => 126
	i64 10092835686693276772, ; 168: Microsoft.Maui.Controls => 0x8c10f49539bd0c64 => 47
	i64 10143853363526200146, ; 169: da\Microsoft.Maui.Controls.resources => 0x8cc634e3c2a16b52 => 3
	i64 10229024438826829339, ; 170: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 66
	i64 10236703004850800690, ; 171: System.Net.ServicePoint.dll => 0x8e101325834e4832 => 118
	i64 10406448008575299332, ; 172: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 85
	i64 10430153318873392755, ; 173: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 64
	i64 10506226065143327199, ; 174: ca\Microsoft.Maui.Controls.resources => 0x91cd9cf11ed169df => 1
	i64 10670374202010151210, ; 175: Microsoft.Win32.Primitives.dll => 0x9414c8cd7b4ea92a => 88
	i64 10714184849103829812, ; 176: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 128
	i64 10785150219063592792, ; 177: System.Net.Primitives => 0x95ac8cfb68830758 => 115
	i64 10822644899632537592, ; 178: System.Linq.Queryable => 0x9631c23204ca5ff8 => 109
	i64 11002576679268595294, ; 179: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 44
	i64 11009005086950030778, ; 180: Microsoft.Maui.dll => 0x98c7d7cc621ffdba => 49
	i64 11103970607964515343, ; 181: hu\Microsoft.Maui.Controls.resources => 0x9a193a6fc41a6c0f => 12
	i64 11162124722117608902, ; 182: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 81
	i64 11220793807500858938, ; 183: ja\Microsoft.Maui.Controls.resources => 0x9bb8448481fdd63a => 15
	i64 11226290749488709958, ; 184: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 45
	i64 11244247448620239658, ; 185: DnsClient => 0x9c0b977add9a0b2a => 38
	i64 11329751333533450475, ; 186: System.Threading.Timer.dll => 0x9d3b5ccf6cc500eb => 145
	i64 11340910727871153756, ; 187: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 65
	i64 11448276831755070604, ; 188: System.Diagnostics.TextWriterTraceListener => 0x9ee0731f77186c8c => 101
	i64 11485890710487134646, ; 189: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 130
	i64 11518296021396496455, ; 190: id\Microsoft.Maui.Controls.resources => 0x9fd9353475222047 => 13
	i64 11529969570048099689, ; 191: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 81
	i64 11530571088791430846, ; 192: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 43
	i64 11597940890313164233, ; 193: netstandard => 0xa0f429ca8d1805c9 => 151
	i64 11705530742807338875, ; 194: he/Microsoft.Maui.Controls.resources.dll => 0xa272663128721f7b => 9
	i64 11743665907891708234, ; 195: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 143
	i64 12040886584167504988, ; 196: System.Net.ServicePoint => 0xa719d28d8e121c5c => 118
	i64 12451044538927396471, ; 197: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 68
	i64 12466513435562512481, ; 198: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 73
	i64 12475113361194491050, ; 199: _Microsoft.Android.Resource.Designer.dll => 0xad2081818aba1caa => 34
	i64 12517810545449516888, ; 200: System.Diagnostics.TraceSource.dll => 0xadb8325e6f283f58 => 102
	i64 12538491095302438457, ; 201: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 61
	i64 12550732019250633519, ; 202: System.IO.Compression => 0xae2d28465e8e1b2f => 105
	i64 12681088699309157496, ; 203: it/Microsoft.Maui.Controls.resources.dll => 0xaffc46fc178aec78 => 14
	i64 12700543734426720211, ; 204: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 62
	i64 12708922737231849740, ; 205: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 140
	i64 12823819093633476069, ; 206: th/Microsoft.Maui.Controls.resources.dll => 0xb1f75b85abe525e5 => 27
	i64 12835242264250840079, ; 207: System.IO.Pipes => 0xb21ff0d5d6c0740f => 107
	i64 12843321153144804894, ; 208: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 46
	i64 12859557719246324186, ; 209: System.Net.WebHeaderCollection.dll => 0xb276539ce04f41da => 120
	i64 13068258254871114833, ; 210: System.Runtime.Serialization.Formatters.dll => 0xb55bc7a4eaa8b451 => 134
	i64 13221551921002590604, ; 211: ca/Microsoft.Maui.Controls.resources.dll => 0xb77c636bdebe318c => 1
	i64 13222659110913276082, ; 212: ja/Microsoft.Maui.Controls.resources.dll => 0xb78052679c1178b2 => 15
	i64 13343850469010654401, ; 213: Mono.Android.Runtime.dll => 0xb92ee14d854f44c1 => 154
	i64 13381594904270902445, ; 214: he\Microsoft.Maui.Controls.resources => 0xb9b4f9aaad3e94ad => 9
	i64 13418404731555841257, ; 215: MongoDB.Driver.Core => 0xba37c00274ce84e9 => 54
	i64 13465488254036897740, ; 216: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 84
	i64 13467053111158216594, ; 217: uk/Microsoft.Maui.Controls.resources.dll => 0xbae49573fde79792 => 29
	i64 13540124433173649601, ; 218: vi\Microsoft.Maui.Controls.resources => 0xbbe82f6eede718c1 => 30
	i64 13545416393490209236, ; 219: id/Microsoft.Maui.Controls.resources.dll => 0xbbfafc7174bc99d4 => 13
	i64 13572454107664307259, ; 220: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 78
	i64 13664641607527540181, ; 221: MongoDB.Libmongocrypt => 0xbda28f24c7b3a5d5 => 55
	i64 13717397318615465333, ; 222: System.ComponentModel.Primitives.dll => 0xbe5dfc2ef2f87d75 => 94
	i64 13755568601956062840, ; 223: fr/Microsoft.Maui.Controls.resources.dll => 0xbee598c36b1b9678 => 8
	i64 13814445057219246765, ; 224: hr/Microsoft.Maui.Controls.resources.dll => 0xbfb6c49664b43aad => 11
	i64 13881769479078963060, ; 225: System.Console.dll => 0xc0a5f3cade5c6774 => 97
	i64 13959074834287824816, ; 226: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 68
	i64 14100563506285742564, ; 227: da/Microsoft.Maui.Controls.resources.dll => 0xc3af43cd0cff89e4 => 3
	i64 14124974489674258913, ; 228: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 61
	i64 14125464355221830302, ; 229: System.Threading.dll => 0xc407bafdbc707a9e => 146
	i64 14254574811015963973, ; 230: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 140
	i64 14461014870687870182, ; 231: System.Net.Requests.dll => 0xc8afd8683afdece6 => 116
	i64 14464374589798375073, ; 232: ru\Microsoft.Maui.Controls.resources => 0xc8bbc80dcb1e5ea1 => 24
	i64 14522721392235705434, ; 233: el/Microsoft.Maui.Controls.resources.dll => 0xc98b12295c2cf45a => 5
	i64 14561513370130550166, ; 234: System.Security.Cryptography.Primitives.dll => 0xca14e3428abb8d96 => 137
	i64 14622043554576106986, ; 235: System.Runtime.Serialization.Formatters => 0xcaebef2458cc85ea => 134
	i64 14634432763299238475, ; 236: Incidenciapp => 0xcb17f30fc9ca124b => 87
	i64 14669215534098758659, ; 237: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 41
	i64 14705122255218365489, ; 238: ko\Microsoft.Maui.Controls.resources => 0xcc1316c7b0fb5431 => 16
	i64 14744092281598614090, ; 239: zh-Hans\Microsoft.Maui.Controls.resources => 0xcc9d89d004439a4a => 32
	i64 14819054087695749454, ; 240: SharpCompress.dll => 0xcda7db2d9467d14e => 56
	i64 14852515768018889994, ; 241: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 65
	i64 14892012299694389861, ; 242: zh-Hant/Microsoft.Maui.Controls.resources.dll => 0xceab0e490a083a65 => 33
	i64 14904040806490515477, ; 243: ar\Microsoft.Maui.Controls.resources => 0xced5ca2604cb2815 => 0
	i64 14935719434541007538, ; 244: System.Text.Encoding.CodePages.dll => 0xcf4655b160b702b2 => 139
	i64 14954917835170835695, ; 245: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 42
	i64 14984936317414011727, ; 246: System.Net.WebHeaderCollection => 0xcff5302fe54ff34f => 120
	i64 14987728460634540364, ; 247: System.IO.Compression.dll => 0xcfff1ba06622494c => 105
	i64 15015154896917945444, ; 248: System.Net.Security.dll => 0xd0608bd33642dc64 => 117
	i64 15076659072870671916, ; 249: System.ObjectModel.dll => 0xd13b0d8c1620662c => 123
	i64 15111608613780139878, ; 250: ms\Microsoft.Maui.Controls.resources => 0xd1b737f831192f66 => 17
	i64 15115185479366240210, ; 251: System.IO.Compression.Brotli.dll => 0xd1c3ed1c1bc467d2 => 104
	i64 15133485256822086103, ; 252: System.Linq.dll => 0xd204f0a9127dd9d7 => 110
	i64 15227001540531775957, ; 253: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 40
	i64 15370334346939861994, ; 254: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 64
	i64 15391712275433856905, ; 255: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 42
	i64 15421195635082552877, ; 256: Incidenciapp.dll => 0xd60317b9a0e6662d => 87
	i64 15527772828719725935, ; 257: System.Console => 0xd77dbb1e38cd3d6f => 97
	i64 15536481058354060254, ; 258: de\Microsoft.Maui.Controls.resources => 0xd79cab34eec75bde => 4
	i64 15557562860424774966, ; 259: System.Net.Sockets => 0xd7e790fe7a6dc536 => 119
	i64 15582737692548360875, ; 260: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 72
	i64 15609085926864131306, ; 261: System.dll => 0xd89e9cf3334914ea => 150
	i64 15661133872274321916, ; 262: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 148
	i64 15664356999916475676, ; 263: de/Microsoft.Maui.Controls.resources.dll => 0xd962f9b2b6ecd51c => 4
	i64 15710114879900314733, ; 264: Microsoft.Win32.Registry => 0xda058a3f5d096c6d => 89
	i64 15743187114543869802, ; 265: hu/Microsoft.Maui.Controls.resources.dll => 0xda7b09450ae4ef6a => 12
	i64 15783653065526199428, ; 266: el\Microsoft.Maui.Controls.resources => 0xdb0accd674b1c484 => 5
	i64 15817206913877585035, ; 267: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 143
	i64 15847085070278954535, ; 268: System.Threading.Channels.dll => 0xdbec27e8f35f8e27 => 142
	i64 15942979176950631493, ; 269: MongoDB.Driver.Core.dll => 0xdd40d71787978c45 => 54
	i64 16018552496348375205, ; 270: System.Net.NetworkInformation.dll => 0xde4d54a020caa8a5 => 114
	i64 16154507427712707110, ; 271: System => 0xe03056ea4e39aa26 => 150
	i64 16219561732052121626, ; 272: System.Net.Security => 0xe1177575db7c781a => 117
	i64 16288847719894691167, ; 273: nb\Microsoft.Maui.Controls.resources => 0xe20d9cb300c12d5f => 18
	i64 16321164108206115771, ; 274: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 44
	i64 16442365378858692411, ; 275: Snappier.dll => 0xe42f04325a0daf3b => 57
	i64 16454459195343277943, ; 276: System.Net.NetworkInformation => 0xe459fb756d988f77 => 114
	i64 16649148416072044166, ; 277: Microsoft.Maui.Graphics => 0xe70da84600bb4e86 => 51
	i64 16677317093839702854, ; 278: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 77
	i64 16737807731308835127, ; 279: System.Runtime.Intrinsics => 0xe848a3736f733137 => 131
	i64 16765015072123548030, ; 280: System.Diagnostics.TextWriterTraceListener.dll => 0xe8a94c621bfe717e => 101
	i64 16890310621557459193, ; 281: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 141
	i64 16933958494752847024, ; 282: System.Net.WebProxy.dll => 0xeb018187f0f3b4b0 => 121
	i64 16942731696432749159, ; 283: sk\Microsoft.Maui.Controls.resources => 0xeb20acb622a01a67 => 25
	i64 16998075588627545693, ; 284: Xamarin.AndroidX.Navigation.Fragment => 0xebe54bb02d623e5d => 75
	i64 17008137082415910100, ; 285: System.Collections.NonGeneric => 0xec090a90408c8cd4 => 91
	i64 17031351772568316411, ; 286: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 74
	i64 17062143951396181894, ; 287: System.ComponentModel.Primitives => 0xecc8e986518c9786 => 94
	i64 17089008752050867324, ; 288: zh-Hans/Microsoft.Maui.Controls.resources.dll => 0xed285aeb25888c7c => 32
	i64 17118171214553292978, ; 289: System.Threading.Channels => 0xed8ff6060fc420b2 => 142
	i64 17154287038065938077, ; 290: AWSSDK.SecurityToken => 0xee10452c7f020e9d => 36
	i64 17179789585722495361, ; 291: AWSSDK.SecurityToken.dll => 0xee6adf9b14f1d181 => 36
	i64 17230721278011714856, ; 292: System.Private.Xml.Linq => 0xef1fd1b5c7a72d28 => 125
	i64 17342750010158924305, ; 293: hi\Microsoft.Maui.Controls.resources => 0xf0add33f97ecc211 => 10
	i64 17438153253682247751, ; 294: sk/Microsoft.Maui.Controls.resources.dll => 0xf200c3fe308d7847 => 25
	i64 17470386307322966175, ; 295: System.Threading.Timer => 0xf27347c8d0d5709f => 145
	i64 17514990004910432069, ; 296: fr\Microsoft.Maui.Controls.resources => 0xf311be9c6f341f45 => 8
	i64 17623389608345532001, ; 297: pl\Microsoft.Maui.Controls.resources => 0xf492db79dfbef661 => 20
	i64 17685921127322830888, ; 298: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 98
	i64 17702523067201099846, ; 299: zh-HK/Microsoft.Maui.Controls.resources.dll => 0xf5abfef008ae1846 => 31
	i64 17704177640604968747, ; 300: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 73
	i64 17710060891934109755, ; 301: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 71
	i64 17712670374920797664, ; 302: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 130
	i64 17777860260071588075, ; 303: System.Runtime.Numerics.dll => 0xf6b7a5b72419c0eb => 133
	i64 17979120673405951447, ; 304: ZstdSharp => 0xf982aafeb83e5dd7 => 86
	i64 18025913125965088385, ; 305: System.Threading => 0xfa28e87b91334681 => 146
	i64 18099568558057551825, ; 306: nl/Microsoft.Maui.Controls.resources.dll => 0xfb2e95b53ad977d1 => 19
	i64 18121036031235206392, ; 307: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 74
	i64 18146411883821974900, ; 308: System.Formats.Asn1.dll => 0xfbd50176eb22c574 => 103
	i64 18245806341561545090, ; 309: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 90
	i64 18305135509493619199, ; 310: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 76
	i64 18324163916253801303 ; 311: it\Microsoft.Maui.Controls.resources => 0xfe4c81ff0a56ab57 => 14
], align 8

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [312 x i32] [
	i32 46, ; 0
	i32 155, ; 1
	i32 50, ; 2
	i32 108, ; 3
	i32 62, ; 4
	i32 79, ; 5
	i32 86, ; 6
	i32 7, ; 7
	i32 144, ; 8
	i32 96, ; 9
	i32 10, ; 10
	i32 67, ; 11
	i32 83, ; 12
	i32 18, ; 13
	i32 75, ; 14
	i32 115, ; 15
	i32 47, ; 16
	i32 154, ; 17
	i32 144, ; 18
	i32 16, ; 19
	i32 37, ; 20
	i32 60, ; 21
	i32 72, ; 22
	i32 111, ; 23
	i32 124, ; 24
	i32 59, ; 25
	i32 129, ; 26
	i32 6, ; 27
	i32 79, ; 28
	i32 28, ; 29
	i32 48, ; 30
	i32 28, ; 31
	i32 136, ; 32
	i32 71, ; 33
	i32 2, ; 34
	i32 20, ; 35
	i32 67, ; 36
	i32 90, ; 37
	i32 24, ; 38
	i32 106, ; 39
	i32 70, ; 40
	i32 127, ; 41
	i32 35, ; 42
	i32 63, ; 43
	i32 135, ; 44
	i32 58, ; 45
	i32 27, ; 46
	i32 113, ; 47
	i32 41, ; 48
	i32 2, ; 49
	i32 127, ; 50
	i32 7, ; 51
	i32 121, ; 52
	i32 83, ; 53
	i32 69, ; 54
	i32 122, ; 55
	i32 133, ; 56
	i32 119, ; 57
	i32 85, ; 58
	i32 50, ; 59
	i32 39, ; 60
	i32 80, ; 61
	i32 152, ; 62
	i32 22, ; 63
	i32 135, ; 64
	i32 40, ; 65
	i32 148, ; 66
	i32 39, ; 67
	i32 151, ; 68
	i32 78, ; 69
	i32 43, ; 70
	i32 48, ; 71
	i32 116, ; 72
	i32 111, ; 73
	i32 126, ; 74
	i32 33, ; 75
	i32 96, ; 76
	i32 53, ; 77
	i32 108, ; 78
	i32 95, ; 79
	i32 30, ; 80
	i32 107, ; 81
	i32 0, ; 82
	i32 58, ; 83
	i32 80, ; 84
	i32 113, ; 85
	i32 132, ; 86
	i32 53, ; 87
	i32 92, ; 88
	i32 92, ; 89
	i32 132, ; 90
	i32 57, ; 91
	i32 129, ; 92
	i32 98, ; 93
	i32 55, ; 94
	i32 26, ; 95
	i32 29, ; 96
	i32 104, ; 97
	i32 138, ; 98
	i32 136, ; 99
	i32 82, ; 100
	i32 103, ; 101
	i32 137, ; 102
	i32 23, ; 103
	i32 23, ; 104
	i32 34, ; 105
	i32 70, ; 106
	i32 56, ; 107
	i32 11, ; 108
	i32 66, ; 109
	i32 45, ; 110
	i32 139, ; 111
	i32 19, ; 112
	i32 22, ; 113
	i32 102, ; 114
	i32 149, ; 115
	i32 147, ; 116
	i32 122, ; 117
	i32 125, ; 118
	i32 106, ; 119
	i32 26, ; 120
	i32 52, ; 121
	i32 110, ; 122
	i32 88, ; 123
	i32 95, ; 124
	i32 147, ; 125
	i32 123, ; 126
	i32 100, ; 127
	i32 112, ; 128
	i32 17, ; 129
	i32 152, ; 130
	i32 38, ; 131
	i32 84, ; 132
	i32 60, ; 133
	i32 131, ; 134
	i32 93, ; 135
	i32 69, ; 136
	i32 99, ; 137
	i32 153, ; 138
	i32 93, ; 139
	i32 51, ; 140
	i32 100, ; 141
	i32 128, ; 142
	i32 52, ; 143
	i32 138, ; 144
	i32 77, ; 145
	i32 37, ; 146
	i32 124, ; 147
	i32 21, ; 148
	i32 153, ; 149
	i32 76, ; 150
	i32 89, ; 151
	i32 21, ; 152
	i32 99, ; 153
	i32 149, ; 154
	i32 31, ; 155
	i32 82, ; 156
	i32 59, ; 157
	i32 35, ; 158
	i32 141, ; 159
	i32 63, ; 160
	i32 91, ; 161
	i32 155, ; 162
	i32 109, ; 163
	i32 49, ; 164
	i32 6, ; 165
	i32 112, ; 166
	i32 126, ; 167
	i32 47, ; 168
	i32 3, ; 169
	i32 66, ; 170
	i32 118, ; 171
	i32 85, ; 172
	i32 64, ; 173
	i32 1, ; 174
	i32 88, ; 175
	i32 128, ; 176
	i32 115, ; 177
	i32 109, ; 178
	i32 44, ; 179
	i32 49, ; 180
	i32 12, ; 181
	i32 81, ; 182
	i32 15, ; 183
	i32 45, ; 184
	i32 38, ; 185
	i32 145, ; 186
	i32 65, ; 187
	i32 101, ; 188
	i32 130, ; 189
	i32 13, ; 190
	i32 81, ; 191
	i32 43, ; 192
	i32 151, ; 193
	i32 9, ; 194
	i32 143, ; 195
	i32 118, ; 196
	i32 68, ; 197
	i32 73, ; 198
	i32 34, ; 199
	i32 102, ; 200
	i32 61, ; 201
	i32 105, ; 202
	i32 14, ; 203
	i32 62, ; 204
	i32 140, ; 205
	i32 27, ; 206
	i32 107, ; 207
	i32 46, ; 208
	i32 120, ; 209
	i32 134, ; 210
	i32 1, ; 211
	i32 15, ; 212
	i32 154, ; 213
	i32 9, ; 214
	i32 54, ; 215
	i32 84, ; 216
	i32 29, ; 217
	i32 30, ; 218
	i32 13, ; 219
	i32 78, ; 220
	i32 55, ; 221
	i32 94, ; 222
	i32 8, ; 223
	i32 11, ; 224
	i32 97, ; 225
	i32 68, ; 226
	i32 3, ; 227
	i32 61, ; 228
	i32 146, ; 229
	i32 140, ; 230
	i32 116, ; 231
	i32 24, ; 232
	i32 5, ; 233
	i32 137, ; 234
	i32 134, ; 235
	i32 87, ; 236
	i32 41, ; 237
	i32 16, ; 238
	i32 32, ; 239
	i32 56, ; 240
	i32 65, ; 241
	i32 33, ; 242
	i32 0, ; 243
	i32 139, ; 244
	i32 42, ; 245
	i32 120, ; 246
	i32 105, ; 247
	i32 117, ; 248
	i32 123, ; 249
	i32 17, ; 250
	i32 104, ; 251
	i32 110, ; 252
	i32 40, ; 253
	i32 64, ; 254
	i32 42, ; 255
	i32 87, ; 256
	i32 97, ; 257
	i32 4, ; 258
	i32 119, ; 259
	i32 72, ; 260
	i32 150, ; 261
	i32 148, ; 262
	i32 4, ; 263
	i32 89, ; 264
	i32 12, ; 265
	i32 5, ; 266
	i32 143, ; 267
	i32 142, ; 268
	i32 54, ; 269
	i32 114, ; 270
	i32 150, ; 271
	i32 117, ; 272
	i32 18, ; 273
	i32 44, ; 274
	i32 57, ; 275
	i32 114, ; 276
	i32 51, ; 277
	i32 77, ; 278
	i32 131, ; 279
	i32 101, ; 280
	i32 141, ; 281
	i32 121, ; 282
	i32 25, ; 283
	i32 75, ; 284
	i32 91, ; 285
	i32 74, ; 286
	i32 94, ; 287
	i32 32, ; 288
	i32 142, ; 289
	i32 36, ; 290
	i32 36, ; 291
	i32 125, ; 292
	i32 10, ; 293
	i32 25, ; 294
	i32 145, ; 295
	i32 8, ; 296
	i32 20, ; 297
	i32 98, ; 298
	i32 31, ; 299
	i32 73, ; 300
	i32 71, ; 301
	i32 130, ; 302
	i32 133, ; 303
	i32 86, ; 304
	i32 146, ; 305
	i32 19, ; 306
	i32 74, ; 307
	i32 103, ; 308
	i32 90, ; 309
	i32 76, ; 310
	i32 14 ; 311
], align 4

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 8

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 8

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 8

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
	store ptr %fn, ptr @get_function_pointer, align 8, !tbaa !3
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
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+fix-cortex-a53-835769,+neon,+outline-atomics,+v8a" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+fix-cortex-a53-835769,+neon,+outline-atomics,+v8a" }

; Metadata
!llvm.module.flags = !{!0, !1, !7, !8, !9, !10}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.2xx @ 0d97e20b84d8e87c3502469ee395805907905fe3"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"branch-target-enforcement", i32 0}
!8 = !{i32 1, !"sign-return-address", i32 0}
!9 = !{i32 1, !"sign-return-address-all", i32 0}
!10 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
