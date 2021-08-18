<div align="center">

![readme splash](https://raw.githubusercontent.com/jeffreylanters/unity-request-review/master/.github/WIKI/repository-readme-splash.png)

[![license](https://img.shields.io/badge/mit-license-red.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-request-review/blob/master/LICENSE.md)
[![openupm](https://img.shields.io/npm/v/nl.elraccoone.request-review?label=UPM&registry_uri=https://package.openupm.com&style=for-the-badge&color=232c37)](https://openupm.com/packages/nl.elraccoone.request-review/)
[![build](https://img.shields.io/badge/build-passing-brightgreen.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-request-review/actions)
[![deployment](https://img.shields.io/badge/state-success-brightgreen.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-request-review/deployments)
[![stars](https://img.shields.io/github/stars/jeffreylanters/unity-request-review.svg?style=for-the-badge&color=fe8523&label=stargazers)](https://github.com/jeffreylanters/unity-request-review/stargazers)
[![awesome](https://img.shields.io/badge/listed-awesome-fc60a8.svg?style=for-the-badge)](https://github.com/jeffreylanters/awesome-unity-packages)
[![size](https://img.shields.io/github/languages/code-size/jeffreylanters/unity-request-review?style=for-the-badge)](https://github.com/jeffreylanters/unity-request-review/blob/master/Runtime)
[![sponsors](https://img.shields.io/github/sponsors/jeffreylanters?color=E12C9A&style=for-the-badge)](https://github.com/sponsors/jeffreylanters)
[![donate](https://img.shields.io/badge/donate-paypal-F23150?style=for-the-badge)](https://paypal.me/jeffreylanters)

Provides a basic implementation for requesting app reviews for mobile apps on the Apple AppStore and Google PlayStore.

[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md)

**Made with &hearts; by Jeffrey Lanters**

</br>

</div>

# Installation

### Using the Unity Package Manager

Install the latest stable release using the Unity Package Manager by adding the following line to your `manifest.json` file located within your project's Packages directory, or by adding the Git URL to the Package Manager Window inside of Unity.

```json
"nl.elraccoone.request-review": "git+https://github.com/jeffreylanters/unity-request-review"
```

### Using OpenUPM

The module is availble on the OpenUPM package registry, you can install the latest stable release using the OpenUPM Package manager's Command Line Tool using the following command.

```sh
openupm add nl.elraccoone.request-review
```

# Documentation

This module focusses on only requesting a review while trying to keep the code as minimalisic as posible wihout prefabs and monobehaviours.

## Usage

Use the RequestReview namespace, and call the Open method in order to open the review request.

```cs
using ElRaccoone.RequestReview;
public class Main {
  private void Start () {
    RequestReview.Open ();
  }
}
```

## iOS 10.3 or newer notes

The module tells StoreKit to ask the user to rate or review your app, if appropriate.

Although you should call this method when it makes sense in the user experience flow of your app, the actual display of a rating/review request view is governed by App Store policy. Because this method may or may not present an alert, it's not appropriate to call it in response to a button tap or other user action.

When you call this method while your app is still in development mode, a rating/review request view is always displayed so that you can test the user interface and experience. However, this method has no effect when you call it in an app that you distribute using TestFlight.

## iOS 10.2 or lower notes

**Coming soon!**

Support for this platform has yet to be implemented.

## Android notes

**Coming soon!**

Support for this platform has yet to be implemented.
