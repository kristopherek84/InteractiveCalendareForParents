using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interactiveCalendareForParents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InteractiveCalendar
{
    [TestClass]
    public class Tests
    {
        private Program _program;
        private Baby _baby;

        [TestInitialize]
        public void Setup()
        {
            _baby = new Baby("Bogusia", DateTime.Parse("16.09.09"));
            _program = new Program(_baby);
          
        }

        [TestMethod]
        public void IsBabysAgeCorrect()
        {

            _baby.AgeInMonths = 10;
            Assert.AreEqual(10, _program.GetAge());
        }

        [TestMethod]
        public void IsFeedingPlanCorrect0to3Months()
        {
            for (int i = 0; i < 4; i++)
            {
                _baby.AgeInMonths = i;
                Assert.AreEqual("The Baby should be breastfead on demand.\n", _program.GetFeedingPlan(true));
                Assert.AreEqual("The Baby should be fead modified milk on demand.", _program.GetFeedingPlan(false));
            }
        }

        [TestMethod]
        public void IsFeedingPlanCorrect4to6Months()
        {
            for (int i = 4; i < 7; i++)
            {
                _baby.AgeInMonths = i;
                Assert.AreEqual(
                    "The Baby should be breastfead on demand.\n Introducing groucery mousse in Manna gruel once a day.",
                    _program.GetFeedingPlan(true));
                Assert.AreEqual(
                    "The Baby should be fead modified milk on demand. Introducing groucery mousse in Manna gruel once a day.",
                    _program.GetFeedingPlan(false));
            }
        }

        [TestMethod]
        public void IsFeedingPlanCorrect7to9Months()
        {
            for (int i = 7; i < 10; i++)
            {
                _baby.AgeInMonths = i;
                Assert.AreEqual(
                    "The Baby should be breastfead on demand.\nExtending " + _baby.Name + " diet should consist of:\n" +
                    "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.",
                    _program.GetFeedingPlan(true));
                Assert.AreEqual(
                    "The Baby should be fead modified milk on demand.Extending " + _baby.Name +
                    " diet should consist of:\n" +
                    "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.",
                    _program.GetFeedingPlan(false));
            }
        }

        [TestMethod]
        public void IsFeedingPlanCorrect10to12Months()
        {
            _baby.AgeInMonths = 10;
            Assert.AreEqual(
                "The Baby should be breastfead on demand.\nExtending " + _baby.Name + " diet should consist of:\n" +
                "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.",
                _program.GetFeedingPlan(true));
            Assert.AreEqual(
                "The Baby should be fead modified milk on demand.Extending " + _baby.Name +
                " diet should consist of:\n" +
                "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.",
                _program.GetFeedingPlan(false));
            for (int i = 11; i < 13; i++)
            {
                
                _baby.AgeInMonths = i;
                Assert.AreEqual(
                    "The Baby should be breastfead on demand.\nExtending " + _baby.Name + " diet should consist of:\n" +
                    "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
                    "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                    "3.Purée from fruit or fruit juice.",
                    _program.GetFeedingPlan(true));
                Assert.AreEqual(
                    "The Baby should be fead modified milk on demand.Extending " + _baby.Name +
                    " diet should consist of:\n" +
                    "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
                    "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                    "3.Purée from fruit or fruit juice.",
                    _program.GetFeedingPlan(false));
            }

        }

        [TestMethod]
        public void VaccinationPlanCorrect()
        {
            for (int i = 0; i < 3; i++)
            {
                _baby.AgeInMonths = i;
                Assert.AreEqual("At the age of 2 months "
                                + _baby.Name +
                                " should receve \nthe second dose of the hepatitis B vaccine, as well as first against diphtheria, \ntetanus and pertussis (DTP), Haemophilus influenzae type b (Hib) bacteria and pneumococcal.",_program.GetVaccinationPlan(true,true,false));
                Assert.AreEqual("At the age of 2 months " + _baby.Name + " should receve the first 6 in 1 vaccine.",_program.GetVaccinationPlan(true,false,true));
            }
            _baby.AgeInMonths = 3;
            Assert.AreEqual("Between the age of 3 and 4 months (6-8weeks after the last vaccination) "
                            + _baby.Name +
                            " should receve \nthe second dose of vaccination against diphtheria, tetanus and pertussis (DTP) , Haemophilus influenzae type b (Hib) bacteria and pneumococcal.\n" +
                            "At this age " + _baby.Name + " should receve the first vaccinaton against acute severe childhood paralysis (poliomyelitis).", _program.GetVaccinationPlan(true, true, false));
            Assert.AreEqual("Between the age of 3 and 4 months " + _baby.Name + " should receve the second 6 in 1 vaccine.", _program.GetVaccinationPlan(true, false, true));
            for (int i = 4; i < 6; i++)
            {
                _baby.AgeInMonths = i;
                Assert.AreEqual("Between the age of 5 and 6 months (6-8weeks after the last vaccination) " +
                                _baby.Name +
                                " should receve \nthe third dose of vaccination against diphtheria, tetanus and pertussis (DTP) , Haemophilus influenzae type b (Hib) \nand the second against polio.", _program.GetVaccinationPlan(true, true, false));
                Assert.AreEqual( "Between the age of 5 and 6 months " + _baby.Name + " should receve the last 6 in 1 vaccine.", _program.GetVaccinationPlan(true, false, true));
             }
            _baby.AgeInMonths = 6;
            Assert.AreEqual("At the age of 7 months " + _baby.Name + " shoud receve third dose of vaccine against hepatitis B.", _program.GetVaccinationPlan(true, true, false));
            Assert.AreEqual(_baby.Name + " should be past the first year vaccination plan.", _program.GetVaccinationPlan(true, false, true));
        }

        [TestMethod]
        public void AreDoctorsAppointmentsCorrect()
        {
            _baby.AgeInMonths = 1;
            Assert.AreEqual("Before the mandatory vaccination your pediatrician should weight and examine " + _baby.Name + " to check for signes of infetion.",_program.GetNearestDoctorsAppointment());
            _baby.AgeInWeeks = 2;
            Assert.AreEqual("The first doctors appointment of " + _baby.Name + " should be between the age of 2 and 4 weeks.\n"
                            + "During this visit " + _baby.Name + " will be weighed and listened to with a stethoscope. \nThe Doctor will see " + _baby.Name + "'s eyes, assess the size of the darkness, measure head circumference, \nexamine the tummy and genitals."
                            + "During this visit the physician \nshould write you an orthopedic referral to see if the child has hip dysplasia."
                            + "\nIf during the examination your doctor will notice any disturbing symptoms, \nhe will refer the referral to another specialist.", _program.GetNearestDoctorsAppointment());
            _baby.AgeInMonths = 4;
            _baby.AgeInWeeks = 16;
            Assert.AreEqual("6 weeks after the last vaccination it's time for the next one. Like before, your pediatrician \nshould weight and examine " + _baby.Name + " to check for signes of infetion."
                            + "\nIf he finds signs of allergy, he'll refer you to an allergist", _program.GetNearestDoctorsAppointment());
            _baby.AgeInMonths = 5;
            Assert.AreEqual("At the age of 6 months a visit to your pediatrician should be made before the third vaccination, \nsame as before. If "
                + _baby.Name + " is poorly gaining weight, \nthe doctor may recommend a blood test to rule out anemia. He'll also assess whether \nadditional doses of vitamin D are needed "
                + "and might advise you how to expand " + _baby.Name + "'s \ndiet to get everything what is needed.", _program.GetNearestDoctorsAppointment());
            _baby.AgeInMonths = 7;
            Assert.AreEqual("At the age of 12 months the pediatrician will examine " + _baby.Name +
                            " \nand will measure the scar after vaccination against tuberculosis (the baby was given the first day of life). \nIf it is less than 3 mm, vaccination will need to be repeated.", _program.GetNearestDoctorsAppointment());
        }

        [TestMethod]
        public void IsGetSkillsCorrect()
        {
            _baby.AgeInMonths = 0;
            Assert.AreEqual(
                "It's time to feed! From the suggested menu I choose your food. \nOops, you will probably have to look in the diaper. Oh yes, now OK. \nTime to nap. Just be with me.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 1;
            Assert.AreEqual(
                "I love it when you hug me. :-) \nHonestly, I like the time spent in your arms almost as much as sleep. \nAnd hm ... home spa: daily bath, olives, gentle massage.My pass is for years.\nOh, well :-(, I admit I cry. I cry a lot, but it's my only way to signal needs.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 2;
            Assert.AreEqual(
                "I can focus my eye's on you now, hi, hi, hi you make funny faces. \nI can already hear and understand the intonation of your voice and I'm training my vocabulary.\nWell, just for now, a gu, gu, bu, mu...and such.\nBut admit that my monologue makes everyone happy. :-) \nOne thing doesn't change ... the need for closeness, tenderness, your delicious milk and a dry diaper.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 3;
            Assert.AreEqual(
                "Ha, ha :-) you noticed, I can hold on to toys, I hold my head stiff when you pull me up to sit down! \nI can also laugh out loud! Most often when you make funny faces.\nOh, what tasty, smooth and round! What is this? Oh, my new rattle. \nI am having fun, and the time to go to examine my hip joints!",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 4;
            Assert.AreEqual(
                "Well! How long can I lie on my stomach? You put me there, but this is not my favorite position. \nI know, I know this is a great exercise for my muscles. \nWhat baby is laughing at me in the mirror? Seriously? I look like this :-) \nCool, but time for little snack!Super, today's first vegetable dinner. \nOh, open the jar! Yummy. Now give me your milk.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 5;
            Assert.AreEqual(
                "I remind you that we have to repeat vaccinations! :-( I do not like this, but it's important. \nThese wooden rods in bed is an invention just in time for me, \nI can hold them and ... oh, oh I sit, hooray! I'm sitting! :-) Uf, but it's tiring. \nYes, now it's time for a walk, at least an hour. You're right, you have to change the diaper. \nGreat, this one is bigger, the previous one was already cramped. But, do not forget to take my juice!",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 6;
            Assert.AreEqual(
                "Hi, hi, hi ... funny, so much confusion, phones to grandparents and aunts. \nAfter all, it's just a tooth. And it's appearance was accompanied with my weeping and your sleepless nights. \nHey, Mom, I do not want to sit in the crib anymore.I prefer to have fun on the educational mat, \nbut I beg you don't leave and do not leave me alone.\nAnd take those little blocks. I can easily hurt myself with them.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 7;
            Assert.AreEqual(
                "Surprise! :-) I'm sitting. Alone, hurray. And ... Attention! I'm trying to crawl.\n So much so that I am relieved to receive daily ritual: nap, walk, evening bath and reading the fairy tale.\nIt's interesting how much energy I have. Yeah. After all, besides your milk and vegetable soup with meat, \nI eat apple jelly. Uuuuu :-( Why does this lady want to take my on her hands? \nShe doesn't know that I'm reluctant to start new relationships.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 8;
            Assert.AreEqual(
                "Sitting is boring. It is more interesting to walk, holding on ... \nAuuu :-( the table moved, buuuuu ball on my forehead hurts.Do something buuuuu.\nThat's enough for today, I prefer play in the penny.I will throw toys on the floor.\nOr not, play with me. Ma, ma, ma, it always works, hmmm my favorite kisses-cuddly. \nOnly daddy's sad. Okay ta, ta, ta, ta happy? Ba, ba, are you going? Bye Bye.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 9;
            Assert.AreEqual(
                "I'm becoming a champion! I can put in and pull out blocks from a box. \nI can clap my hands, drink from the cup and as a gift for my parents ... \na successful attempt to pee into the potty.\nBut, without exaggeration, it's safer in a diaper! What smells so? Mmmm, delicious :-) \nDid you bake it youself? \nYummy yeast cake, a royal supper.",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 10;
            Assert.AreEqual(
                "I invite you to an acrobatic show. Success: sit down, get up, take a few steps straight holding on to something, \na few sideways, a couple on my knees :-) Now a wooden disc on a stick hops ... one more and another. \nWhat do you think about that?Kiss. No, don't take my book, I'm watching it. \nAlright, I'm done. Are going for a walk? Just do not dress me thick.\nLater I'll have those tiny itchy pustules.How do you call them? Oh, pots.\nMake me a sandwich with roast meat!",
                _program.GetBabysSkills());
            _baby.AgeInMonths = 11;
            Assert.AreEqual(
                "Time to check my achievements :-) I eat with a spoon. Okay, sometimes the soup still land on the table, but ... \nI have some teeth! Haven't you made a mistake? Count again.\nI pee on a potty, although I still prefer a diaper. I say: mom, dad, baba. \nI know where on the picture is a dog and a cow. What? Am I praising to much? \nWell, maybe. Uuuuu, what's this? birthday cake! Blow, how to blow? I love you most in the world :-)",
                _program.GetBabysSkills());
        }

    }
}
