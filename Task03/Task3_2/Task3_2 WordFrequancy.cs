using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "It is at this time that White Fang is separated from his mother, who is sold off to another Indian Camp by Three Eagles. " +
                "He realizes how hard life in the wild is when he runs away from camp, and earns the respect of Grey Beaver when he saves his " +
                "son Mit-Sah from a group of boys seeking revenge. When a famine occurs, he runs away into the woods and encounters his mother " +
                "Kiche, only for her to chase him away, for she has a new litter of cubs. He also encounters Lip-Lip, whom he fights and kills " +
                "before returning to the camp. When White Fang is five years old, he is taken to Fort Yukon, so that Grey Beaver can trade " +
                "with the gold-hunters.There, when Grey Beaver is drunk, White Fang is bought by an evil dog - fighter named Beauty Smith.White " +
                "Fang defeats all opponents pitted against him, including several wolves and a lynx, until a bulldog called Cherokee is brought " +
                "in to fight him.Cherokee has the upper hand in the fight when he grips the skin and fur of White Fang's neck and begins " +
                "to throttle him. White Fang nearly suffocates, but is rescued when a rich, young gold hunter, Weedon Scott, stops the fight, " +
                "and forcefully buys White Fang from Beauty Smith.";
            var dict = Frequancy(text);
            foreach (var item in dict)
            {
                Console.WriteLine("Слово {0} встетилось в тексте {1} раз(а)",item.Key,item.Value);
            }

        }
        public static Dictionary<string, int> Frequancy(string text)
        {           
            var arr = text.ToUpper().Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var item in arr)
            {
                if (dictionary.ContainsKey(item)) dictionary[item]++;
                else dictionary.Add(item, 1);
            }
            return dictionary.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}
