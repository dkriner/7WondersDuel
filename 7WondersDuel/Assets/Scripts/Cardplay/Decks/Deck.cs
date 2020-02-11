
enum CONFIG_LOC_STATE { BLANK = 0, OPEN = 1, CLOSED = 2 }

namespace Duel
{
    interface Deck
    {
        Card[] Cards { get; set; }
        uint Age { get; set; }
        CONFIG_LOC_STATE[][] Config { get; set; }

        void Shuffle();

        void Deal();
    }
}

