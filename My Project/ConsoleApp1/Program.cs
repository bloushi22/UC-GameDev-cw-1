// Hero
string heroName = "Link" ;
float heroHeight = 169.5f;
int heroAge = 117 ;
string heroSuperPower = "Swordsmanship" ;

// Villain

string villainName = "Ganon" ;
float villainHeight = 463.7f;
int villainAge = 517 ;
string villainSuperPower = "Immense Strenght" ;

// Difference
int ageDifference = villainAge - heroAge;

Console.WriteLine("Once upon a time in the Kingdom of Hyrule , There was a Hero. His name was " + heroName + ". His height was " + heroHeight + " and in the age of " + heroAge + ". The people of Hyrule known him as a champion with his great " + heroSuperPower + " skills with his Master Sword.");
Console.WriteLine(heroName + " tries to save Hyrule from " + villainName + ". Who was known with his massive size " + villainHeight + " and for his long life age " + villainAge + ". Our hero must be aware of " + villainSuperPower + " of his enemy and try to sealed him.");
Console.WriteLine("The age difference between our hero and villian is " + ageDifference);
