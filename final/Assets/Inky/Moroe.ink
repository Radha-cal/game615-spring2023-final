You enter the mysterious house, feeling as if you are at the culmination of your journey. Or perhaps it is just beginning.
You see a strange, high tech looking elevator clashing with the worn rotten wood of the ancient house. It's only big enough for one person, so you need to go alone.
+[Enter]
-You descend deeper and deeper into the water until you see a beautiful underground laboratory. 
You see a woman with unkept long curly hair in an old labcoat with a pin with the initials MM on them.
"Hello. It's so great to finally meet you." she says.
+[Who are you, and how do you know my name?]
-"I've been keeping tabs on you. Set out from Davenport with nothing but a raft, and now you arrive here on an atomic warship. I've given it a few upgrades by the way, I hope you don't mind. You won't have to worry about  monsters or pirates anymore, you can travel anywhere on the river like its nothing. You're welcome!"
+[Thank you??]
+[You can't mess with my ship without asking me! Tell me who you are!]
-"Marva. Marva Moroe. Doctor Marva Moroe. And I know you've heard this over and over again but I have a job for you. But its not some errand at the behest of some powerful figure or cult or Corporation. This is an errand to destroy power itself."
+[That's... A little frightening...]
+[You know what, I'm kinda into that.]
-"I'll tell you more, but I need to truly trust you first. This machine is a teleporter. It will take you directly to the headquarters of the Metronomicon in Davenport. This +pulls a pistol from her pocket+ is a gun. *She tosses it towards you.* I'm gonna teleport you to the Regional Manager's office, you shoot that bastard in the head, and I'll send your ship over to the port. Once you shoot him, jump out of the window on the left. Not the right! The left. And you will be teleported you back before you fall. Safe and Sound! Ok. 3, 2, 1..."
+[Wha-]
->Teleport
+[Hey!]
->Teleport
+[Sto-]
->Teleport
===Teleport===
-You teleport into a room. It must be the manager's office, but it's far from being empty. You see a tour guide leading some people around. There is no one sitting in the General Manager's Chair. Maybe you should wait for them to leave? Or maybe you should abandon this crazy plan and get out of here!
+[Listen to Tour guide]
+[Jump out right window]
-> FallDamage
+[Jump out left window]
->FailEsc
-"...And this is the general manager's office! He's grabbing lunch right now, but when he's here he's overseeing the opperations of the entire Davenport- Mississippi Sector! Isn't that wild! And you new recruits will be the ones incharge of the Metronomicon's largest expansion since Mojave! And that's the end of the tour! Feel free to grab lunch and explore your new offices!"
+[Next]
-Someone in the crowd next to you starts talking to you. 
"Wow, this is so exciting! I'm Brent by the way, I'm super excited to be working with you! what's your name!"
+[Hey Brent. Do you know where the lunch room is?]
-"Oh sure! It's right this way! Wow, I cannot tell you how nice it is to finally find a friend here. Everyone's so climb the corporate ladder and stomp on everyone else, you know!"
+[Nice to make a new friend too, Brent]->Friend
+[I wouldn't go as far as saying we're friends. I mean, I hardly know you.]->Aquant
===Friend===
"Let's stick together, OK? We'll have each other's back."

You suddenly  see a man walking back from the cafeteria. It has to be the Regional Manager!
+[Sorry Brent, I need to go.]->Assassination
===Aquant===
Well, I guess that's true. But you're the nicest person I've met my entire first day. Is it just me, or are people here just super competitive?]
+[Ehh, Average Corporation you know? They all suck.]
->badCorp
+[I can be a little meaner if that helps.]
->Mean

 ===badCorp===
 "Wait, if you don't like Corporations, how'd you get all the way up here?"

You suddenly  see a man walking back from the cafeteria. It has to be the Regional Manager!
+[Sorry Brett, I need to go.]
->Assassination

===Mean===
"Are you joking? Sorry, I'm bad at tellling what's a joke and what's serious. Social interactions are NOT my forte."

You suddenly  see a man walking back from the cafeteria. It has to be the Regional Manager!
+[Sorry Brett, I need to go.]
->Assassination
===Assassination===
You run after the Regional Manager. You catch him alone in his office. you pull out your gun... only to find it not there.
"Hey buddy, I think you dropped this... gun? Oh. Oh no..."


+[Brent! Toss me the Gun!]
->Toss
+[Shoot him Brett!]
->Brent
+[Well, I guess this is the end.]
->Giveup
===Toss===
Chet tosses you the gun and you catch it. You point it at the regional manager.
The manager laughs.
"You're Marva's latest attempt to stop us, huh? She's getting desperate. I love that. You may be of use to me. How would you like an executive position at the Metronomicon? You spy for me. A little double agent action."
+[After what you did to Davenport? No way! Brett, Please shoot him!]
->Brent
+[I guess I'll accept. Marva kinda roped me into this]
->Accept
===Giveup===
The manager laughs.
"You're Marva's latest attempt to stop us, huh? She's getting desperate. I love that. You may be of use to me. How would you like an executive position at the Metronomicon? You spy for me. A little double agent action."
+[After what you did to Davenport? No way! Brett, Please shoot him!]
->Brent
+[I guess I'll accept. Marva kinda roped me into this]
->Accept
===Accept===
Good. Brett, lovely first day, but you've been reassigned. You are now our lovely assasins handler. I am dead, that news will hit the stands as soon as you leave. It's the perfect cover for our latest expansion. Go back, tell the lie, get the info, then sail back to Davenport. You now have free access to our facilities. You can come to room 1312, and I'll meet you. Refuse to comply, and the consequences will be rather severe.]
+[I accept. (Jump out of right window with Brett)]-> FallDamage
+[I accept. (Jump out of left window with Brett)]->SavedBrett
+[I refuse. (Die)]->FallDamage
===Brent===
Brent shoots the Regional Manager, killing him.
"Why did I do that! Why did I do that!"
+[Grab Brent and Jump out of the right window]
-> FallDamage
+[Grab Brent and Jump out of the left window]
->SavedBrett
+[Leave Brent and Jump out of the right window]
-> FallDamage
[Leave Brent and Jump out of the left window]"
->LeftBrent
 ===FailEsc===
 "You didn't kill him! It's ok, I'll send you back"
 +[Wait Wait Wait!!]
 ->Teleport
===FallDamage===
You died. Restart Mission?
+Restart 
    ->Teleport
===SavedBrett===
You and Brent teleport back right before you hit the floor. You are holding the gun. Brent is shocked.
"OH MY GOD. What just happened? I'm like, freaking out right now!"
Marla appears, excited. "I see you have a stowaway.  Should I kill him, or should i send him back to your ship?"
+[Kill Him]
->Kill
+[Send him to my ship]
->BrentParty
===Kill===
Brett Looks at you, deeply betrayed.
"What!! Noo-"
Brett disintegrates in front of your eyes.
+[Next]->Ending
===BrentParty===
Brett is deeply confused, but goes along with it
Well, I guess I'm joining your crew! See you later, friend!
+[Next]->Ending
===LeftBrent===
You teleport back right before you hit the floor. 
Marla appears, excited. "Welcome back."
+[Next]->Ending
===Ending===
Marla smiles."Excellent. You've done good work today. Really good work. The news has already spread like wildfire. I think you can be trusted with the truth. The whole truth.
+[Next]
-"The Apocalypse was supposed to bring us together. Destroy the old world and bring in an era of human liberation. But it was too slow. It was floods over decades, the people in power took to long to respond and people died. All that's left in the old Mississippi are the scraps and remnants. The Flumen Apocalypta was of no value. But then I found value."  
+[Next]
-"A Scientist of the Metronomicon, I found rumors of long lost genetics research lost when New Orleans flooded so long ago. But they only saw it as competition. They forced me never to dig it up. 
We lost a world of kings and queens and CEO's only to build another one up. It's because the apocolypse wasn't a true apocalypse. It needed to be... final."
+[Next]
-"But now, I have the power to make a real one. I sent you over there because I wanted the CEO to make his way here. I want that wretched company, and all the wretched companies and Queens and Kings and Rulers to see their end." 
+[Next]
-You watch as the windows of the laboratory, once showing the beautiful ocean floor, get covered by shadows, You seem to see tentacles, or fins, or something. All you know is it's larger than any creature you have ever encountered.
"This is the true power of the Flumen Apocalypta"
+End of Chapter 1
->END

