#import <StoreKit/StoreKit.h>

/// Opens the Request Review popup on the iOS device.
void _RequestReviewOpenInternal() {

  /// When running iOS 10.3 or newer, the requestReview method will be used.
  if (@available(iOS 10.3, *)) {
    [SKStoreReviewController requestReview];
  } 

  /// When running any lower version, the AppStore review deep-link will be used.
  else {
    // TODO implement this method.
    // https://apps.apple.com/app/idXXXXXXXXXX?action=write-review
  }
}