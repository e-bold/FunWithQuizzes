using FunWIthQuizzes;

Quiz quiz = new Quiz();

string q1Prompt = "Who of these famous people are from St. Louis?";
Choice[] q1Choices =
[
    new Choice("Brad Pitt"),
    new Choice("Nelly", true),
    new Choice("President William McKinley"),
    new Choice("Jenna Fischer", true)
];
CheckBox q1 = new(q1Prompt, q1Choices);


string q2Prompt = "There are currently three Ted Drewes locations in St. Louis.";
TrueFalse q2 = new(q2Prompt, false);



string q3Prompt = "How tall is the Gateway Arch?";
Choice[] q3Choices =
[
    new Choice("530ft"),
    new Choice("645ft"),
    new Choice("590ft"),
    new Choice("630ft", true)
];
MultipleChoice q3 = new(q3Prompt, q3Choices);

quiz.questions.AddRange([q1, q2, q3]);

quiz.Run();





