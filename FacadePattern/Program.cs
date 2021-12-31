// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using FacadePattern;

ShopFacade.getInstance().BuyProductByCashWithFreeShipping("ke@gpcoder.com");
ShopFacade.getInstance().BuyProductByPaypalWithStandardShipping("kevin@gmail.com");
