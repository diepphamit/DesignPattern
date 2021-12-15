// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ObserverPattern;
using ObserverPattern.Notifiers;

var videoData = new VideoData();

var emailNotifier = new EmailNotifier(videoData);
_ = new PhoneNotifier(videoData);
_ = new YoutubeNotifier(videoData);

videoData.SetTitle("aaaaa");

videoData.DetachObserver(emailNotifier);
Console.WriteLine("--------------------------");

videoData.SetDescription("aaaaa11");



