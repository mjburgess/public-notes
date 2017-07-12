##

=begin

Introduction

This is an unfinished article which may be of interest to programmers, philosophers with an interest and perhaps some academically-minded lay people. I have made it available now in its early draft stage, as I welcome comments and feedback.

Here I attempt to answer are some questions I take to be relevant to the philosophy of programming. Many more need to be added, and mostly, my answers are incomplete or answered quite briefly and technically. This will change as I expand it towards a general audience.

“The Philosophy of Programming” only weakly exists: though I have seen seminars offered at Harvard and a University in Denmark. It is as I see it, primarily a conjunction of the philosophy of science and the philosophy of mind – with as much metaphysics and epistemology as might be expected.

There are a handful of departments which have tried to unify many concerns across philosophy into a “Philosophy of Computer Science”. My concerns here however, are narrower.

At the end of this article I list several technical and philosophical resources.

Overview

Introduction

Overview.. 

What is Programming?

What are Programs?

How does the program text relate to the running program?

Do imperative languages mean the same thing as declarative languages?

What are programmers doing when they program?

Can Computers Program?

What is a successful program?

Does the program solve the problem?

The origin of bugs.

Why is Software Always Buggy?

What is it to design according to a problem?

How do changes in the problem domain affect the programmer?

Is agile the best approach to Good Programming?

How does Agile Work?

Rougher Sketches & Ideas...

What is it to think in the “terms” of a language?

Does the program accurately describe the problem?

Are some paradigms better at representing problems than others?

What is Programming?

Making programs.

What are Programs?

The text of a program is an expression of a programmer's understanding. An understanding acquired, in part, by problem solving. By living in the problem. By experiencing the world and having a view on which aspects are relevant. On the selection of a small slice of it from these experiences: “the problem domain”. A domain which becomes represented in language: the source text. A text whose meaning is then discarded, in translation to the meaningless oscillations of an electrical field guided somehow by the intention of the programmer.

Programming therefore requires causal contact with the world and ability to understand one’s perceptions, ideas, concerns, and other faculties in a reflective, creative and analytical mode.

Therefore, the program text (“source”) is a representation of the problem domain. The running program is the solution to that problem.

Compare with a painting:  the “text” of the painting represents the scene, looking-at the painting is the process of being informed about the scene.

In the case of paintings, looking (running-the-painting) has a primarily informative purpose.

The text of the program and the running machine code are as distinct as the painting and the visual experience the on-looker has of it. With a painting – “running” is a process from oil to mental states via light. The “running” painting is the mental state (ie., specific neurochemical state) that contact with the light scattered off the canvas causes.

By creating a causal pathway from “text” to specific kinds of electrical oscillation – “compilation” --  we are able to operate conceptually in the conceptual domain of the problem without worrying about electrical concerns.

As the painter can operate in the domain of oil, colour and shape – and not in the domain of the neuroscience of human visual perception.

How does the program text relate to the running program?

The text of a program undergoes very many translations. Over and over and over again is the most general language rewritten into, ultimately, millions of commands eventually sent to the processor.

One line of code in a “high-level” language may, in the end, correspond to millions of 0s and 1s: millions of electrical oscillations.

There is therefore no hope, in modern programming at least, in trying to solve problems by tracking the changes to the CPU surface.

Equally, of course, the painter would have no hope taking a needle to the visual cortex of a human being and prodding it just so his patient would experience his painting. Far easier for the painter to put oil on his canvas and let the translatory processes of the human neural system create the final running state: that of the experience the on-looker has of the painted canvas.

This is a mysterious process. Though its mystery lies, perhaps, primarily in its complexity. We can isolate each step in the causal change and understand its origin and final point. And we can step back an observe how these steps run millions of times.

The CPU operates successfully because it is a machine which builds safe, reliable and predicable complexity from simplicity.

Do imperative languages mean the same thing as declarative languages?

An imperative language is one which describes problems as a series of actions. A declarative language is one which describes problems in terms of what the solution should look like.

So they do not mean the same thing.

While the running program is, in a sense, metaphorically imperative (ie., it is a series of electrical actions occurring in a processor) there is no need to express the problem as a series of actions. The metaphorically “imperative” nature of the final 0s and 1s does not erase fundamental distinctions at the level of the text.

The imperative (action-by-action) paradigm was selected when it was important to allow the programmer to see in text what the likely efficiency of the running program would be. To make the text as representative of the running as possible, and not the problem.

Representing the problem was left to stray comments, interspersed among the assembly. Comments, nevertheless, are part of the program text – so this isn’t a disaster for accuracy.

What are programmers doing when they program?

Not just typing!

Programming is understanding a problem domain in the terms a programming language provides. That could, often, be achieved through writing in the language. Or it could be achieved whilst showering, gardening or taking a brisk walk.

Can Computers Program?

A digital computer is an electrified piece of mental whose extended electrical field oscillates in a way which, metaphorically, “follows rules”. The oscillation is not confined to the CPU: it is distributed across the CPU, RAM, and so on… all the way to the display. It is the display’s capacity to translate this into light which gives the computer an appearance of life. In much the same way that a children’s flick book appears to present living cartoon characters.

It is highly doubtful that any system of this kind can solve a problem: ie., think creatively, analytically, embedded in a series of concerns and priorities.

There is a superstition, frequent in the history of human culture, that thinking is some magical process. Rather, thinking is a bodily process. Thinking is something animals do because they undergo specific sorts of neurochemical reactions. Thinking is not something wood, sand, water nor metal (however cleverly electrified) does.

The neuroscientist will never learn anything about cognition by throwing out all of his brains and animals and instead turning to the structure of silicon.

Specific processes which occur in the world do so because the objects they involve have specific actions on one another (“causes”). The reason that glass is transparent is because of the specific way it interacts with light. The reason the stomach digests pizza is because of its regulated acidity. The reason thinking happens is because of the extended and complex interactions of the nervous system.

All a digital computer may do is simulate this process, that is, describe the form of these interactions.

A computer simulating digestion cannot be fed pizza. A computer simulating transparency won’t become transparent. A computer simulating consciousness will not start thinking: it has no nervous system.

The superstition that a “simulation” will become the thing it is simulating is an ancient mistake. It is no different to thinking of cargo cultists who though if they simulated an airport, planes would land. Nor any different to children, who watching cartoons, take bug’s bunny’s simulating of consciousness to be consciousness: bugs bunny is not the kind of thing which thinks. It is not an animal, it is a fiction.

This then should answer very clearly the initial question: can computers program? No. A computer has no concerns, nor creativity, nor experience. The computer cannot understand, nor imagine. The computer does not know what is relevant. Why? Because these are events which occur in advanced brains, and only quite advanced ones, not in any old hunk of stuff.

What is a successful program?

There are (at least!) two independent sets of criteria for success: operational (“the management”) and representational (“the programmer”).

1.	Does the program solve the problem?

2.	Does the program accurately describe the problem?

Does the program solve the problem?

The operational test can seem straightforward: does it work?

However there are very many (epistemological) issues with testing: How do you know it works?

Rarely is the operation of something easily characterised as taking a small-set of input states to a small set of some other output states – but involves an (almost?) infinite number of possible initial states and evolutionary events leading to an almost infinite number of final states.

For example, the uppercase() program should accept every string of text and produce one of every string of text!

The type of that program may be written   String to String

where ‘String’ denotes the infinite set of all pieces of text, ie., {a, aa, aaa, …, b, bb, bbb, …, abc… , A, AA, AAA,… B, BBB…}.

So this program takes any member of this infinite set to one other member of the same set.

eg., a to A  ;   michael to  MICHAEL

It is impossible to guarantee this.

You cannot test every initial state. You test the important ones. You test many (every?) evolutionary rules on these and compare the final state to the expected. At a certain point you say, “all the ones that I have seen behave the way I expect”.

Which only leaves open the problem of induction: merely because you have seen success many times, that provides no guarantee that it will occur every time.

I am not guaranteed the sun will rise tomorrow, no matter how often it has done before.

Problem of induction is “solved” with abduction: you hypothesize causal relationships and use past observations as evidence for these causal relationships.

The reason I believe the sun will rise tomorrow isn't merely that it has risen every day previous, but that I believe there to be a sun in orbit around the earth which obeys the laws of gravity (etc.). It is my confidence in these laws which increase, to a very high degree, my confidence the sun will rise tomorrow. Much more than the mere series of past observations.

Equally with software we can hypothetically relate the evolution of final state to the initial state by way of rules we take the program to follow by way of the design of the program. We increase our confidence that the program is correct because in addition to merely observing its correctness, we note that it has been designed to be correct.

And so…

The origin of bugs

Kinds of Errors: syntax, logical, incorrect design, invalidated design.

Why is Software Always Buggy?

If we’re designing to a problem, what happens when that problem changes?

Programmers try to anticipate generalities that need to be designed for according to probable evolution of the problem.

There is a point where the marginal cost to develop a new feature under the old paradigm exceeds the cost to redevelop the entire program – why?  Try designing an electric car, then when finished, convert it to petrol! And perhaps, see if you can add a windmill.

How much would it cost to add a petrol engine to an electric car? If it is more than several thousand, then it is more than a new car.

(Since I don’t know much about cars, this might not be true – but you get the idea).

What is it to design according to a problem?

A problem is not general: to design to solve every problem is to recreate the entire universe. Problems are strange things, they are often subtly unlike the world we’re used to and its ordinary human concerns.

Consider getting to work via car/train/etc. Does the problem domain require we model cars as having wheels? No, indeed the inclusion of wheels in the program would signify a failure to understand the problem!

When teaching a student how to bake you do not remark on the colour of the walls in the kitchen: to include this information as part of the baking process would be to misunderstand baking. “Baking” is a narrow set of concerns which selects only some objects, and only in some ways, out of the infinite number of potential descriptions of a kitchen (including say, describing it in terms of the cosmic rays moving through).

Suppose now a manager asks: “what is the efficiency, per wheel, of travelling on cars vs. Planes?” . Or “can you update our baking program, so that the only chocolate cakes are baked if the walls are blue?.

Perhaps the company was starting to manufacture wheels. Or perhaps, the school has now colour-coded its kitchens. This shift in concerns, quite radical looking at how our prior design would play out, does not register as radical to the manager. It may not even appear as a shift in the problem when it is in fact a radical reorganisation of the domain.

Why? Because the manager fails to clearly distinguish the problem domain of “living with its usual concerns” from that which concerns the program and the problem. If we make this distinction clearly the introduction of wheels (or wall colour) is no trivial matter.

How do changes in the problem domain affect the programmer?

The radical shift of a small problem domain to one concerned with wheels does not translate to an obvious radical reorganisation of the entire code base – of course it might, but it might not. It depends on the generalities that occurred to the programmer in his design, and his consideration for what might change.

However these changing design constraints frequently introduce the most serious and profound technical changes to a code base, smothered over with the usual label of “technical debt” (which is paid-off by the programmer).

Is agile the best approach to Good Programming?

Programming is most successful when writing according to an exactly and perfectly understood problem domain. Programming is at its least successful when it operates under constantly changing design constraints.

We should distinguish, in programming, from iterative development and iterative specification.

Iterative development is the usual process by which a programmer evolves the descriptive accuracy of a code base according to his understanding of the problem domain. Preferably through prototypical versions which are each discarded in favour of a final design which perfectly expresses his understanding.

Iterative specification is a radically different process by which the programmer is handed radically different shifts to the problem domain.

Agile can be iterative in either sense. But let’s observe how catastrophic “iterative specification” is to the accuracy of code bases. At least, to how frequently its costs – written off as “technical debt” – overwhelm projects.

This isn't a criticism of agile as such: it solves very many management problems. And in cases where a clear specification cannot be produced, or is poorly understood, iterative evolution of a specification could be preferable.

But compared to the ideal case of programming, as in the ideal of case of painting, the subject of the program must be still!

The painter, looking at a still subject, iteratively develops the painting: layering each part, using an eraser as appropriate. But! He does not iterate on his specification. He does not half finish a painting and decide it really ought to be of a different kind of scene entirely. And if he does, the sane painter starts from a new or washed canvas.

In the case of programming, developers are asked to use Mona Lisa's smile as the frame of a bridge on a new architectural diagram. To reuse clearly profoundly inadequate old descriptions as the basis for a new one.

This shouldn't be taken as saying agile leads to a worse development process. It might be that there are just so frequently barriers to ‘Good Development’ that a non-agile process, in practice, leads to more catastrophic results.

I only discuss the process here to point out that its concern is not to improve programming directly by offering a practice which its suited to the ideal situation for the programmer: it is the reverse, and inspire of doing exactly the opposite of what enables Good Programming, it may produce better programs. (plausible – but I am sceptical of usual justifications).

How does Agile Work?

By distributing power and information “efficiently” so that those who get information (purportedly) are those who need it. So that not too much control, nor too much responsibility, and therefore not too much information finds itself around the team.

This, in my experience, provides a barrier to a good understanding of the problem domain. An architect, with a mind to shield the programmers from all of the technical details of the hosting (eg. data centre) situation, prescribes a methodology which makes no sense to programmers outside this context.

Programmers therefore inevitably, perceiving the traditional approach to be easier, head in that direction on occasion “for only this feature” and misunderstand the problem domain.

And this occurs between business analysts, technical architects, clients, and everyone else.

The business analyst communicates via wire frames and documentation the overview of the problem domain from the customer’s point of view. A state to state journey of evolution in function.

This is not the problem domain in toto, since it fails to add “as provided on AWS, using Elastic Search, etc.” That the solution architect, or TA, will add in.

Indeed the entire problem domain, and its understanding, its distributed across the team. This is narrowly efficient, but I am sceptical that “self-organisation” is broadly efficient.

Everyone each makes mistakes because they are missing what others know, and through these mistakes acquire more information about the problem. The process is repeated in each case where a series of mistakes must occur in order for information to more effectively spread to everyone – and everyone needs it!

Agile seems, in practice, a process of organized confusion.

Do the BA’s need to know what the technical considerations of running on the cloud are? If they do, can they be understood by BA?

I suspect the answer to the former is Yes, and the latter No – so we are in a puzzle.

It may be that Agile is the most effectively solution to this antagonism. It may be that confusion is inevitable and the best position to be in is one where the confusion is managed.

But courts manage to appeal to juries. Rarely, in practice, is there a miscarriage of justice because a lawyer is unable to explain the technical details of the law.

Perhaps TAs, BAs  -- and everyone else needs to become practiced in articulating their present understanding of the problem domain as simply, and early, and frequently as possible.

Rougher Sketches & Ideas...

What is it to think in the “terms” of a language?

The lagnauge of programers is full of strange terms, consider the claim, “this class should have more fields”. What do the terms ‘class’ and ‘fields’ refer to?

ASIDE: We can say These “terms” form the ontology of the language: the abstract objects (eg. Class, function, etc.) that each term refers to.

The claim “The class should have more fields” is true iff the class should have more fields. With this taskian/quinean approach we can map out the ontology of language. So let’s just take the manual and start there?

This is the denotational approach to programming semantics and ends up with mathematical objects.

Does the program accurately describe the problem?

Joint-carving. Program must be accurate to the problem, not “to the world” (by which we usually mean ordinary human concerns).

Problem needs to be identified clearly along lines of concern.

 

Are some paradigms better at representing problems than others?

Eg. Pure functional programming vs. Object oriented programming

In one change is the calculation of a new value from an old one. In another it is (more or less) an event concerning an object whose internal state is updated.

There are lots of grounds that might be persuasive to chose pure functional programming (eg. equational reasoning is easier, debugging easier, etc.) that seem little to do with accurate representation. And yet it appears as if the paradigm makes a substantial difference to the way a design is phrased.

However most the most clearly identifiable site of design is the type system and both approach use effectively similar kinds of type rules (OR, AND, Polymorphism). And OO programs can accidentally instantiate rules that are merely formally specified in a more functional type system (eg. That BankAccount is monoidal).

Within a paradigm it is easier to say what it is for a design to misdescribe a problem (eg. An object composes together disparate fields:  A Car does is not composed of a road).

Even here we can bring concerns to bare on the design of the program that are no obviously to do with accuracy. Even if a car is not a composite of road-mental, it might still be “simpler” for a program to pretend that it is.

In which case perhaps we’re in a dyamic equilibrium between program simplicity and the problem domain: we change the problem domain in order to make the program simpler.

Accuracy can be maintained by changing the model, or sticking to the model and changing the problem!







=end

##