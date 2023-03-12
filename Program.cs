using tpmodul4_1302210095;
using static tpmodul4_1302210095.DoorMachine;

internal class Program
{
    private static void Main(string[] args)
    {
        KodePos bandung = new KodePos();

        Console.WriteLine("Beberapa kode pos dari kelurahan yang ada di bandung:");
        Console.Write(Convert.ToString(KodePos.Kelurahan.Kebonwaru) + "\t");
        Console.WriteLine(bandung.getKodePos(KodePos.Kelurahan.Kebonwaru));
        Console.Write(Convert.ToString(KodePos.Kelurahan.Batununggal) + "\t");
        Console.WriteLine(bandung.getKodePos(KodePos.Kelurahan.Batununggal));
        Console.Write(Convert.ToString(KodePos.Kelurahan.Kujangsari) + "\t");
        Console.WriteLine(bandung.getKodePos(KodePos.Kelurahan.Kujangsari));

        Console.WriteLine("\n");

        //State-Base
        Console.WriteLine("Hasil implementasi state base, Door Mechine:");
        DoorMachine pintuDoraemon = new DoorMachine();
        pintuDoraemon.currentState = DoorMachine.DoorState.TERKUNCI;

        Console.Write("Current State: ");
        Console.WriteLine("PINTU " + ((pintuDoraemon.currentState == DoorState.TERKUNCI) ? "TERKUNCI" : "TIDAK TERKUNCI"));
        Console.WriteLine();

        pintuDoraemon.activeTrigger(DoorMachine.Trigger.BUKAPINTU);
        pintuDoraemon.activeTrigger(DoorMachine.Trigger.KUNCIPINTU);
        pintuDoraemon.activeTrigger(DoorMachine.Trigger.KUNCIPINTU);
        pintuDoraemon.activeTrigger(DoorMachine.Trigger.BUKAPINTU);

    }
}