# What's this?

This repository shows a problem with nested ListViews and Editors in Xamarin.Forms.
I tested it on Android and don't know if the problem is also present on iOS.

## So... What problem are we talking about?

On the ItemsPage (the initial view) there is a ListView with Editors in the items representing cells.
Each item can have subitems. These are also being displayed inside a nested ListView.

If you try to Edit the 4th or 5th subitem's entry (you have to scroll down a bit) then the keyboard doesn't show up.

When you try to edit a regular item (not a subitem) and then tap on a subitem, then the keyboard will be displayed.


[Xamarin.Forms forum thread](https://forums.xamarin.com/discussion/comment/379591)