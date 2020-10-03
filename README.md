# Animation Screens

## Home

![Alt text](screenshots/title.png?raw=true "Title")

# Buy me a coffee!

If this was useful to you, buy me a coffee to make my day!

<a href="https://www.buymeacoffee.com/nav2kar" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

## Heartbeat Animation
### Source Code
```csharp
   await Task.WhenAll<bool>
    (
        heart.ScaleTo(2, 1000),
        heart.FadeTo(0, 1000, Easing.SinInOut)
    );

    await Task.WhenAny<bool>
    (
        heart.ScaleTo(1, 0),
        heart.FadeTo(1, 0)
    );
```

### Screenshot

| ![Alt text](screenshots/heart.png?raw=true "Title") |


## Apple Shake Animation
### Source Code
```csharp
  new Animation {
    { 0, 0.125, new Animation (v => profile.TranslationX = v, 0, -13) },
    { 0.125, 0.250, new Animation (v => profile.TranslationX = v, -13, 13) },
    { 0.250, 0.375, new Animation (v => profile.TranslationX = v, 13, -11) },
    { 0.375, 0.5, new Animation (v => profile.TranslationX = v, -11, 11) },
    { 0.5, 0.625, new Animation (v => profile.TranslationX = v, 11, -7) },
    { 0.625, 0.75, new Animation (v => profile.TranslationX = v, -7, 7) },
    { 0.75, 0.875, new Animation (v => profile.TranslationX = v, 7, -5) },
    { 0.875, 1, new Animation (v => profile.TranslationX = v, -5, 0) }
}
.Commit(this, "AppleShakeChildAnimations", length: 500, easing: Easing.Linear, finished: (x, y) => _isAnimating = false);
```

### Screenshot

| ![Alt text](screenshots/appleshake.png?raw=true "Title") |




## References

* [Generate Gradients ](https://www.gradientmagic.com/)
