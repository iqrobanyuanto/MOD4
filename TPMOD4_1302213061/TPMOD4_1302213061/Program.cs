// See https://aka.ms/new-console-template for more information
KodePos pos = new KodePos();
pos.GetKodePos();
Console.WriteLine("\n");
DoorMachine door = new DoorMachine(DoorMachine.StateMasuk.Terbuka);
door.cekState();
door.trigger(DoorMachine.StateAction.Kunci_Pintu);
door.cekState();