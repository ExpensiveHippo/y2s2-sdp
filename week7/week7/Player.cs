using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week7.Commands;

namespace week7
{
    internal class Player
    {
        private static Player? uniqueInstance = null;
        private int hp;
        public int Hp { get => hp; set => hp = value; }
        private int maxHp;
        public int MaxHp { get => maxHp; set => maxHp = value; }
        private int mp;
        public int Mp { get => mp; set => mp = value; }
        private int maxMp;
        public int MaxMp { get => maxMp; set => maxMp = value; }
        private int magicPower;
        public int MagicPower { get => magicPower; set => magicPower = value; }

        public Command[] slots;
        private Stack<Command> commandHistory;



        private Player(int maxHp, int maxMp, int magicPower)  
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
            this.maxMp = maxMp;
            this.mp = maxMp;
            this.magicPower = magicPower;
            this.slots = new Command[12];
            this.commandHistory = new Stack<Command>();

            for (int i = 0; i < 12; i++)
            {
                slots[i] = new NoCommand();
            }
        }

        public static Player GetInstance(int maxHp = -1, int maxMp = -1, int magicPower = -1)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Player(maxHp, maxMp, magicPower);
            }
            return uniqueInstance;
        }

        public void SetCommand(Command command, int slot)
        {
            slots[slot] = command;
        } 

        public void UndoKeyPushed()
        {
            if (commandHistory.Count > 0)
            {
                commandHistory.Pop().Undo();
            }
        }

        public void HotKeyPushed(int slot)
        {
            slots[slot].Execute();
            commandHistory.Push(slots[slot]);
        }
    }
}
