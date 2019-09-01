using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Yieldlove.RNReactNativeYieldlove
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeYieldloveModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeYieldloveModule"/>.
        /// </summary>
        internal RNReactNativeYieldloveModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeYieldlove";
            }
        }
    }
}
