using Oyster.Core.AbstractTypes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Assets.Lib.OysterInterop
{
    internal class U_ScriptLoader : A_BackgroundAssetLoader<string>
    {
        // Private Variables
        private string _assetName;
        private AsyncOperationHandle<TextAsset> _handle;

        // Constructor
        public U_ScriptLoader(string assetName)
        {
            // Pass value
            _assetName = assetName;
        }

        // Private Methods
        private void LoadDone(AsyncOperationHandle<TextAsset> obj)
        {
            // Set value
            _asset = obj.Result.text;

            // Was it successful?
            if (_handle.Status == AsyncOperationStatus.Succeeded)
            {
                // Yup
                InvokeOnAssetLoad(LoadResult.Succeeded);
            }
            else
            {
                // Nup
                InvokeOnAssetLoad(LoadResult.Failed);
            }
        }

        // Public Methods
        public override void BeginAssetLoad()
        {
            // Begin loading asset
            _handle = Addressables.LoadAssetAsync<TextAsset>(_assetName);

            // Sub to completion
            _handle.Completed += LoadDone;
        }
    }
}
