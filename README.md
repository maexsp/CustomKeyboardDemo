# CustomKeyboardDemo
Xamarin custom keyboard for Xamarin.Android and Xamarin.IOS.

Initla demo of Android - Numberic Keyboard based on Xamarin.Forms (for Android only) cause of bad Samsung Keyboard support regarding Numeric input with localized Decimal and +/- support. Probably also with other Android vendors.

See E.g. https://developer.samsung.com/forum/board/thread/view.do?boardName=SDK&messageId=361518&startId=zzzzz~&searchType=ALL&searchText=decimal 

- Solved: 
  - Closing of keyboard on custom "ok" key
  - Custom key layout


- TODO
  - Do not overlap actual focues EditText element (if its close to the bottom of the view)
  - Localize dynamically for decimal separator '.' or ','
  - Add key to jump directly to the next editable element
  - Take away focus from actual EditText element if "ok" key gets pressed
  - Light color theme
  - No multiline EditText if Enter key clicked
  - Test with differenct android vendors and also E.g. bluetooth convertible android keyboard
  - Test different keyboard layouts (DE, EN, Chinese, RU, PL, .... )
  - Test iOS: There the default numeric iOS keyboard should be shown. Be aware that iPhone and iPad numeric keyboards behviour can be different


![alt text](https://github.com/maexsp/CustomKeyboardDemo/blob/master/XamarinFormsAndroidCustomKeyboard.png)

