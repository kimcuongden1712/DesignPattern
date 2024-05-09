using Behavioral_StatePattern;

OriginalObject staek = new OriginalObject();
while (staek.Temperature < 160)
{
    staek.Cook();
}