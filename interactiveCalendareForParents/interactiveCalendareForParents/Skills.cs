using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    public class Skills:IBabyInfo
    {
        protected Baby Baby;
        private string[] _babySkills;
        protected string BabySkills;

        public Skills(Baby baby)
        {
            Baby = baby;
            BabySkills= GetBabySkills(Baby);
        }

      

        private string GetBabySkills(Baby baby)
        {
            _babySkills = new string[] {
                "It's time to feed! From the suggested menu I choose your food. \nOops, you will probably have to look in the diaper. Oh yes, now OK. \nTime to nap. Just be with me.",
                "I love it when you hug me. :-) \nHonestly, I like the time spent in your arms almost as much as sleep. \nAnd hm ... home spa: daily bath, olives, gentle massage.My pass is for years.\nOh, well :-(, I admit I cry. I cry a lot, but it's my only way to signal needs.",
                "I can focus my eye's on you now, hi, hi, hi you make funny faces. \nI can already hear and understand the intonation of your voice and I'm training my vocabulary.\nWell, just for now, a gu, gu, bu, mu...and such.\nBut admit that my monologue makes everyone happy. :-) \nOne thing doesn't change ... the need for closeness, tenderness, your delicious milk and a dry diaper.",
                "Ha, ha :-) you noticed, I can hold on to toys, I hold my head stiff when you pull me up to sit down! \nI can also laugh out loud! Most often when you make funny faces.\nOh, what tasty, smooth and round! What is this? Oh, my new rattle. \nI am having fun, and the time to go to examine my hip joints!",
                "Well! How long can I lie on my stomach? You put me there, but this is not my favorite position. \nI know, I know this is a great exercise for my muscles. \nWhat baby is laughing at me in the mirror? Seriously? I look like this :-) \nCool, but time for little snack!Super, today's first vegetable dinner. \nOh, open the jar! Yummy. Now give me your milk.",
                "I remind you that we have to repeat vaccinations! :-( I do not like this, but it's important. \nThese wooden rods in bed is an invention just in time for me, \nI can hold them and ... oh, oh I sit, hooray! I'm sitting! :-) Uf, but it's tiring. \nYes, now it's time for a walk, at least an hour. You're right, you have to change the diaper. \nGreat, this one is bigger, the previous one was already cramped. But, do not forget to take my juice!",
                "Hi, hi, hi ... funny, so much confusion, phones to grandparents and aunts. \nAfter all, it's just a tooth. And it's appearance was accompanied with my weeping and your sleepless nights. \nHey, Mom, I do not want to sit in the crib anymore.I prefer to have fun on the educational mat, \nbut I beg you don't leave and do not leave me alone.\nAnd take those little blocks. I can easily hurt myself with them.",
                "Surprise! :-) I'm sitting. Alone, hurray. And ... Attention! I'm trying to crawl.\n So much so that I am relieved to receive daily ritual: nap, walk, evening bath and reading the fairy tale.\nIt's interesting how much energy I have. Yeah. After all, besides your milk and vegetable soup with meat, \nI eat apple jelly. Uuuuu :-( Why does this lady want to take my on her hands? \nShe doesn't know that I'm reluctant to start new relationships.",
                "Sitting is boring. It is more interesting to walk, holding on ... \nAuuu :-( the table moved, buuuuu ball on my forehead hurts.Do something buuuuu.\nThat's enough for today, I prefer play in the penny.I will throw toys on the floor.\nOr not, play with me. Ma, ma, ma, it always works, hmmm my favorite kisses-cuddly. \nOnly daddy's sad. Okay ta, ta, ta, ta happy? Ba, ba, are you going? Bye Bye.",
                "I'm becoming a champion! I can put in and pull out blocks from a box. \nI can clap my hands, drink from the cup and as a gift for my parents ... \na successful attempt to pee into the potty.\nBut, without exaggeration, it's safer in a diaper! What smells so? Mmmm, delicious :-) \nDid you bake it youself? \nYummy yeast cake, a royal supper.",
                "I invite you to an acrobatic show. Success: sit down, get up, take a few steps straight holding on to something, \na few sideways, a couple on my knees :-) Now a wooden disc on a stick hops ... one more and another. \nWhat do you think about that?Kiss. No, don't take my book, I'm watching it. \nAlright, I'm done. Are going for a walk? Just do not dress me thick.\nLater I'll have those tiny itchy pustules.How do you call them? Oh, pots.\nMake me a sandwich with roast meat!",
                "Time to check my achievements :-) I eat with a spoon. Okay, sometimes the soup still land on the table, but ... \nI have some teeth! Haven't you made a mistake? Count again.\nI pee on a potty, although I still prefer a diaper. I say: mom, dad, baba. \nI know where on the picture is a dog and a cow. What? Am I praising to much? \nWell, maybe. Uuuuu, what's this? birthday cake! Blow, how to blow? I love you most in the world :-)"
            };
            return _babySkills[Baby.AgeInMonths];
        }

        public string GetBabyInfo()
        {
            return BabySkills;
        }
    }
}
