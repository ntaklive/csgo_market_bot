# CS:GO market bot

A program designed to automate the purchase of CS:GO weapons on the steam market with a certain float value.

## Screenshot

![Main Window](https://i.imgur.com/r7NKPge.jpg)

## How to add weapon to list:
1) Go to the steam market weapon page ([like this](https://steamcommunity.com/market/listings/730/P250%20|%20Boreal%20Forest%20(Field-Tested))).
2) Copy any '[Inspect in Game...](steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M4421956023454017443A22947280464D5045336153953192904)' link and put this into 'Link' text box.
3) Enter the upper limit of the 'float' value.
4) Enter the upper limit of the 'price' value.
```
## !!! Important !!!
It is necessary to indicate the 'price' in the same 'currency' as specified in the settings 
```

## How do I sign in to my account? 
1) Go to "settings" and click "account".
2) Log in to your account.

## How to add multiple identical weapons?
Hold 'CTRL' and press 'ADD'.

## Parser Script Settings:
```
Count: [10-100] - The number of lots received during the update.
Currency: [1..n] - Currency that is shown when updating.
Language: [english, russian, ...] - Language that is shown when updating.
Country: [RU, BY, ...] - I don't know what it does...
Filter: [sticker, ...] - Search filter.
```
#### Currency codes:
1 - $;
2 - £;
3 - €;
4 - CHF;
5 - RUB;
6 - zł;
7 - R$;
8 - ¥;
9 - kr;
10 - Rp;
11 - RM;
12 - P;
13 - S$;
14 - ฿;
15 - ₫;
16 - ₩;
17 - TL;
18 - ₴;
19 - Mex$;
20 - CDN$;
21 - A$;
and other...
## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
MIT License

Copyright (c) 2021 ntaklive

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
