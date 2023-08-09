using _04_事件和委托;



Publish publisher = new Publish("发布者");

Subscribe subscriber1 = new Subscribe("小白");
Subscribe subscriber2 = new Subscribe("小红");
Subscribe subscriber3 = new Subscribe("小蓝");

//subscriber可以把自己不同的需求委托给publisher(可以增加和减少)
publisher.Others_Event_Delegate += subscriber1.Action1;
publisher.Others_Event_Delegate += subscriber2.Action2;
publisher.Others_Event_Delegate += subscriber3.Action1;


publisher.Event();//触发关键Event