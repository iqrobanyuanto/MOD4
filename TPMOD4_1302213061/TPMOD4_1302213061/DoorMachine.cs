using System;
using System.Runtime.Versioning;
using System.Transactions;

public class DoorMachine
{	
	//Define attribute
	public enum StateMasuk {Terkunci, Terbuka}
	public enum StateAction {Buka_Pintu,Kunci_Pintu}
	
	public StateMasuk prev;
	public StateAction act;
	public StateMasuk currentState;

	public DoorMachine(StateMasuk awal)
	{
		currentState = awal;
    }
	public StateMasuk door(StateMasuk prev, StateAction act)
	{
		StateMasuk nextState = prev;
		if(prev == StateMasuk.Terkunci && act == StateAction.Buka_Pintu) {
			nextState = StateMasuk.Terbuka;
		}else if(prev == StateMasuk.Terbuka && act == StateAction.Kunci_Pintu)
		{
			nextState = StateMasuk.Terkunci;
		}

		return nextState;

	}

	public void trigger(StateAction act)
	{
		currentState = prev;
		StateMasuk next = door(currentState, act);
        currentState = next;
    }

	public void cekState()
	{
		Console.WriteLine(currentState);
	}
}
