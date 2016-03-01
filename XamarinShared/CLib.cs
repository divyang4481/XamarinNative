using System.Runtime.InteropServices;

namespace XamarinShared
{
    public static class CLib
    {
#if __IOS__
        [DllImport("__Internal", EntryPoint = "clib_add")]
#else
        [DllImport("libCLib", EntryPoint = "clib_add")]
#endif
        public static extern int Add(int left, int right);
    }
}
