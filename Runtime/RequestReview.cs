using UnityEngine;

#if UNITY_IOS == true && UNITY_EDITOR == false
using System.Runtime.InteropServices;
#endif

namespace ElRaccoone.RequestReview {

  /// Request Review module.
  public static class RequestReview {

#if UNITY_IOS == true && UNITY_EDITOR == false
    /// Imports the internal method from the native objective-c class.
    [DllImport ("__Internal")]
    private static extern void _RequestReviewOpenInternal ();
#endif

    /// Opens the Request Review popup.
    public static void Open () {
#if UNITY_IOS == true && UNITY_EDITOR == false
      _RequestReviewOpenInternal ();
#endif
    }
  }
}