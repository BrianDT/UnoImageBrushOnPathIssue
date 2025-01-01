# UnoImageBrushOnPathIssue
Sample for a non filled path shape issue

The UI presents 3 shapes:
1. A rectangle
2. A rectranular path
3. A curved path

On Android the shapes are not filled at all.

Fills correctly on Windows, WASM and iOS.

The documentation indicating that image brushes do not work on WASM needs updating.

Sample on Github https://github.com/BrianDT/UnoImageBrushOnPathIssue

Reported as Uno Platform issue #19142
https://github.com/unoplatform/uno/issues/19142

Issue title:
On Android shapes filled with an image brush do not display the image

Current behavior:
The primary concern was for filled paths, but rectangles do not seem to fill either if there are other shapes on the page.

Typical usage is
```
    <Page.Resources>
        <ImageBrush x:Key="SampleImageBrush" Stretch="Fill" ImageSource="ms-appx:///Assets/FillImage.png" />
    </Page.Resources>


                <Path Canvas.Left="120"
                      Canvas.Top="0"
                      Data="M 100,100 C 160,30 240,30 300,100 L 280,120 C 220,60 180,60 120,120 Z"
                      Fill="{StaticResource SampleImageBrush}"
                      Stroke="Crimson" StrokeThickness="1"/>
```

Expected behavior:
Shapes should be filled as they are on other platforms
