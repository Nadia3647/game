VAR trust = 0
VAR speakerName = ""
VAR mainName = "Мейра"
VAR dragonName = "Соларион"
VAR meatTaken = false
VAR long = 0

EXTERNAL Show(characterName, position, mood)

EXTERNAL Hide(characterName)

-> Day2

== Day2
    
= Room2
    Я проснулась от настойчивого голоса бабушки
    {Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Вставай, тебе на учёбу пора. Спускайся завтракать.
    {Show("main", "_1_5", "Fine")}
    ~ speakerName = mainName
    Доброе утро, бабушка! Уже спускаюсь!
    {Hide("grandma")}
    ~ speakerName = ""
    Мне так хорошо спалось, и был такой чудесный сон! Но пора собираться на учёбу.
    {Hide("main")}
-> Kitchen2

= Kitchen2
    Спускаясь вниз, я думала о своём сне, мне никогда так хорошо не спалось.
    {Show("main", "_1_5", "Fine")}{Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Садись, соня, сегодня первый учебный день. Надо хорошо поесть.
    ~ speakerName = mainName
    Конечно. Знаешь, мне снился такой замечательный сон.
    ~ speakerName = "Бабушка"
    Правда? И какой же?
    ~ speakerName = mainName
    Мне снилось, как я нашла в лесу дракона, приручила его, и он стал жить у нас в амбаре. Жаль, что это был сон...
    ~ speakerName = "Бабушка"
    Да жаль, что не сон! Теперь и правда этот дракон живёт в амбаре.
    ~ speakerName = mainName
    Правда? Так! Мне уже пора идти, а то опоздаю... Хе-хе.
    ~ speakerName = "Бабушка"
    Ну ладно, иди тогда...
    {Hide("grandma")}
    ~ speakerName = ""
    После того, как я быстро доела еду, которую приготовила бабушка, я решила...
        * [взять с собой немного мяса]
            ~ meatTaken = true
            ~ trust += 1
        -> Go
        * [скорее пойти]
        -> Go
        
= Go
    Пойду-ка я в амбар.
    {Hide("main")}
-> Barn2

= Barn2
    В амбаре был дедушка, он что-то делал, но дракона я не видела.
    {Show("main", "_1_5", "Fine")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дедушка"
    А чего ты не идёшь на учёбу?
    ~ speakerName = mainName
    Мне приснился сон, что в лесу был раненый дракон, я его приручила, и теперь он живёт у нас в амбаре. Бабушка сказала, что это не сон, и я решила это проверить, но тут только ты...
    ~ speakerName = "Дедушка"
    Бабка не соврала, это всё правда было, и дракон здесь. Вот только сейчас он отдыхает, поэтому лучше не тревожить его.
    ~ speakerName = mainName
    Как замечательно. Наверное, ты прав, пусть отдыхает. А что ты делаешь?
    ~ speakerName = "Дедушка" 
    Да так, ерунда. Строю ему площадку для тренировок.
    ~ speakerName = mainName
    Зачем? Мы же его только вылечим и отпустим. Да и мы вовсе не знаем как нужно тренировать драконов...
    ~ speakerName = "Дедушка"
    Даже если и не тренировать, ему надо как-то восстановить силы, когда мы его вылечим.
    ~ speakerName = mainName
    Точно! Я и не подумала об этом. Тогда может тебе помочь?
    ~ speakerName = "Дедушка"
    Да нет. Хотя... Купи-ка после университета гвоздей, а то они уже заканчиваются.
    ~ speakerName = mainName
    Хорошо, будет сделано. А ещё передай ему {meatTaken:это мясо.|привет от меня!}
    ~ speakerName = ""
    {Hide("grandpa")}{Hide("main")}
    Выйдя из амбара, я пошла к пикапу. День начался просто замечательно!
-> University

= University
    {Show("main", "_1_5", "Fine")}{Show("Aisha", "_4_5", "Fine")}
    ~ speakerName = "Студентка"
    Привет, {mainName}!!! Ты как?
    ~ speakerName = mainName
    Привет, Айша. Всё просто замечательно, а ты как?
    ~ speakerName = "Айша"
    Да ты и сама всё знаешь. Отдыхала там, сям, шоппинг, коктейли и всё такое.
    ~ speakerName = mainName
    А-ха-ха-ха, и правда, чего я спрашиваю.
    ~ speakerName = "Айша"
    А ты чего такая радостная?
    ~ speakerName = mainName
    Да так, просто я рада видеть тебя.
    ~ speakerName = "Айша"
    Конечно, ещё бы ты не была рада, а-ха-ха! Я тоже соскучилась.
    ~ speakerName = ""
    Мы с Айшей подружились с самого первого дня в университете. Как оказалось, она дочка мэра города. Раньше я думала, что они все избалованные и думают только о себе, но Айша оказалась другой.
    ~ speakerName = mainName
    Ладно, пора на пары.
    ~ speakerName = "Айша"
    Ох, опять эти пары...
    {Hide("Aisha")}{Show("Archi", "_4_5", "Fine")}
    ~ speakerName = "Студент"
    А вот и наш укротитель драконов, или точнее сказать, укротительница? Всё мечтаешь о своём личном драконе, которого никогда не будет? А-ха-ха-ха!
    {Hide("Archi")}{Show("Aisha", "_4_5", "Fine")}
    ~ speakerName = "Айша"
    Отвали, Арчи. Если твой отец такой крутой, это не даёт тебе права задирать других.
    {Hide("Aisha")}{Show("Archi", "_4_5", "Fine")}
    ~ speakerName = "Арчи"
    Да ты что, а кто меня остановит? Ты? Или может быть наша укротительница коров?
    ~ speakerName = mainName
    Если ты не знал, я из города, а живу на ферме, потому что там мои родственники, тупица.
    ~ speakerName = "Арчи"
    И что, фермерша? Мне плевать.
    ~ speakerName = ""
    От злости я замахнулась на Арчи, но он поймал мою руку. Арчи наклонился и прошептал мне на ухо:
    ~ speakerName = "Арчи"
    Ударишь меня, и последствия тебе очень не понравятся.
    ~ speakerName = mainName
    Мы это ещё посмотрим.
    {Hide("Archi")}
    Все пары прошли в раздумьях о том, как бы поставить Арчи на место но и выйти из воды сухой.Я была зла на него, ведь Арчи уже не первый год издевается надо мной, но когда в последнем семестре он узнал, что мне интересны драконы и я хотела стать укротителем драконов, это стало для него наилучшей почвой для насмешек. А сам как был тупым, так и остался. Вот с кем, а с Арчи я хотела снова увидеться на занятиях в последнюю очередь.
    Когда пары закончились, я хотела скорее покинуть университет, только чтобы не видеть его.
    {Show("Aisha", "_4_5", "Fine")}
    ~ speakerName = "Айша"
    {mainName}, подожди меня, ты куда так спешишь?
    ~ speakerName = mainName
    Хочу уйти подальше, чтобы опять не встретить Арчи.
    ~ speakerName = "Айша"
    Не бери в голову его слова. Ты же знаешь, что его девиз "Сила есть - ума не надо".
    ~ speakerName = mainName
    Это ты точно подметила. Не хочешь со мной прокатиться? Мне нужно в магазин стройматериалов.
    ~ speakerName = "Айша"
    Что ты там забыла?
    ~ speakerName = mainName
    Дедушка попросил купить гвозди, ничего особенного.
    ~ speakerName = "Айша"
    Хорошо, если мы потом прогуляемся ещё.
    ~ speakerName = ""
        * [Согласиться]
        ~ speakerName = mainName
            Хорошо, было бы тяжело тебе отказывать.
            -> Drive
        * [Отказаться]
        ~ speakerName = mainName
            Прости, но мне надо будет ехать на ферму потом.
            -> Drive

= Drive
    ~ speakerName = "Айша"
    В любом случае я тебя не брошу! Пойдём уже за твоими... гайками, или как их там?
    ~ speakerName = mainName
    Гвоздями.
    ~ speakerName = "Айша"
    Да, точно. Именно за ними.
    ~ speakerName = ""
    {Hide("Aisha")}{Hide("main")}
    Мы сели в пикап и поехали в магазин стройматериалов. Айша была не в восторге от моей "новой" машины, но отказываться было уже поздно.
-> Store

= Store
    {Show("main", "_1_5", "Fine")}{Show("Aisha", "_4_5", "Fine")}
    ~ speakerName = mainName
    Я быстро, не беспокойся.
    ~ speakerName = "Айша"
    Я спокойна, но всё равно, давай быстрее.
    {Hide("Aisha")}
    ~ speakerName = ""
    Я пошла искать гвозди в этом большом магазине, пока Айша осталась на диванчике у входа.
    ~ speakerName = mainName
    Да где же они!?
    {Show("Emmet", "_4_5", "Fine")}
    ~ speakerName = "Консультант"
    Вам помочь?
    ~ speakerName = mainName
    ...
    ~ speakerName = "Консультант"
    С вами всё хорошо?
    ~ speakerName = mainName
    Ах, да. Всё в порядке. Вы что-то сказали?
    ~ speakerName = "Консультант"
    Я спрашиваю, вам помочь?
    ~ speakerName = mainName
    Знаете... Эммет...
    * [Это было бы здорово]
        ~ speakerName = "Эммет"
        Так что вы ищете?
        ~ speakerName = mainName
        Мне нужны гвозди, никак не могу найти их.
        ~ speakerName = "Эммет"
        Идём за мной, я покажу, где они.
        ~ speakerName = ""
        Я шла за Эмметом, будто загипнотизированная вампиром, который тащит меня в своё логово.
        ~ speakerName = "Эммет"
        Вот мы и пришли.
        ~ speakerName = mainName
        Спасибо большое! Без тебя я бы тут целую вечность проторчала!
        ~ speakerName = "Эммет"
        Вау, так сильно меня ещё не благодорили!
        ~ speakerName = mainName
        Ну, ты это заслужил. Спасибо ещё раз!
        ~ speakerName = "Эммет"
        Не за что. Заходи почаще, буду рад помочь.
        ~ speakerName = mainName
        {Hide("Emmet")}
        Постараюсь!
        -> Next
    * [Спасибо, но я справлюсь сама.]
        ~ speakerName = "Эммет"
        Хорошо, если понадоблюсь, обращайтесь.
        ~ speakerName = ""
        {Hide("Emmet")}
        Консультант не спеша отошёл и я решила пойти в... -> Search
= Search
    ~ speakerName = ""
    * [Северный отдел]
        ~ long += 1
        Придя в этот отдел, я увидела стеллажи с грунтовкой, цементом, бочками и тому подобным.
        ~ speakerName = mainName
        Тут их нет, может, сходить в... -> Search
    * [Западный отдел]
        ~ long += 1
        Это отдел красок, тут только краски и кисточки.
        ~ speakerName = mainName
        Тут их нет, может, сходить в... -> Search
    * [Восточный отдел] 
        Зайдя в этот отдел, я увидела молотки, шуруповёрты, пилы и тому подобное, но главное среди них были гвозди!
        ~ speakerName = mainName
        Я нашла!!! Наконец-то!
        ~ speakerName = ""
        -> Next

= Next
    Я купила гвозди и пошла к Айше.
    {Show("Aisha", "_4_5", "Fine")}
    {long == 0:
    ~ speakerName = "Айша"
    А ты и правда быстро, неожиданно.
    ~ speakerName = mainName
    Я просто везучая.
    - else:
    {long == 1:
    ~ speakerName = "Айша"
    А говорила, что быстро.
    ~ speakerName = mainName
    Прости, я немного заблудилась.
    - else:
    ~ speakerName = "Айша"
    Ну неужели, я думала, что останусь тут ждать тебя, как Хатико.
    ~ speakerName = mainName
    Прости меня, я заблудилась.
    }
    }
    ~ speakerName = ""
    {Hide("Aisha")}{Hide("main")}
-> City

= City
    Выйдя из магазина, мы увидели мужчину, пролетающего на драконе. Это был укротитель.
    ~ speakerName = "Всадник"
    Внимание! 4-го числа будут проходить соревнования драконов среди учеников укротителей драконов! Не пропустите столь захватывающее зрелище!
    {Show("main", "_1_5", "Fine")}{Show("Aisha", "_4_5", "Fine")}
    ~ speakerName = ""
    Укротитель драконов улетел.
    ~ speakerName = mainName
    Не знала, что укротители драконов проводят соревнования.
    ~ speakerName = "Айша"
    Ничего особенного, тупые соревнования проводятся каждые 12 лет, чтобы выбрать новых членов совета укротителей драконов. Сильнейший становится старейшиной, последний раз победил отец Арчи.
    ~ speakerName = mainName
    Ха, так вот почему он весь из себя такой.
    ~ speakerName = "Айша"
    Да. В детстве он был другим, более добрым что ли.
    ~ speakerName = mainName
    Да уж, слава его отца погубила его ум.
    ~ speakerName = "Айша"
    Наверно, ты права, либо он сам по себе тупица, а-ха-ха.
    ~ speakerName = mainName
    Не исключено, хи-хи.
    Кстати, было бы здорово посмотреть на эти соревнования, не хочешь пойти со мной?
    ~ speakerName = "Айша"
    Ты серьёзно?
    ~ speakerName = mainName
    Ну Айша, ну пожалуйста. Ты же знаешь, как мне интересны драконы.
    ~ speakerName = "Айша"
    Ладно, так и быть. Тогда попрошу папочку достать нам лучшие места.
    ~ speakerName = mainName
    Спасибо!!!
    ~ speakerName = "Айша"
    А теперь пошли гулять.
    ~ speakerName = ""
    Прогулка с Айшей была великолепной, я так соскучилась по ней за лето.
    {Hide("Aisha")}
    После того, как мы попрощались, я незамедлительно поехала на ферму, чтобы проведать дракона.
    {Hide("main")}
-> Farm2

= Farm2
    Когда я зашла в амбар, дедушка всё ещё делал препятствия для дракона.
    {Show("main", "_1_5", "Fine")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дедушка"
    А вот и ты, как учёба?
    ~ speakerName = mainName
    Хорошо, единственное, опять этот Арчи...
    ~ speakerName = "Дедушка"
    Он снова тебя задирал!? Да я его как Тузик грелку порву!
    ~ speakerName = mainName
    Дедушка, не нужно. Правда, всё нормально.
    ~ speakerName = "Дедушка"
    Ну ладно. Но если что, я готов это сделать, только скажи. Не позволю, чтобы мою внучку обижали!
    ~ speakerName = mainName
    Кстати, 4-го числа будут проводить соревнования укротителей драконов, я собираюсь туда пойти.
    ~ speakerName = "Дедушка"
    Что ты сказала? Фантастика! Вот и твой шанс исполнить свою мечту - стать укротителем драконов.
    ~ speakerName = mainName
    Я имела ввиду просто посмотреть, а не участвовать! Тем более, я же девочка, да и там нужен дракон...
    ~ speakerName = "Дракон"
    Р-р-а-а-а!
    ~ speakerName = mainName
    Ах да, точно. У нас ведь есть дракон... дикий дракон...
    ~ speakerName = "Дедушка"
    Я думаю, он будет не против, мы с ним немного сдружились. Так он отплатит за помощь ему.
    ~ speakerName = mainName
    Ладно, допустим, у нас есть дракон, но как мы обойдём то, что я девочка?
    ~ speakerName = "Дедушка"
    Ничего, ты замаскируешься, а я тебя зарегистрирую как спонсор.
    ~ speakerName = mainName
    Но все же знают, что у тебя внучка и ты фермер, а значит, ты не сможешь выступить в качестве спонсора.
    ~ speakerName = "Дедушка"
    Да, об этом я не подумал...
    ~ speakerName = ""
    И тут в моей голове созрел план, кто мог бы организовать всё это для меня.
    ~ speakerName = mainName
    У меня тут появилась идея, кто может помочь, но пока что я ведь принесла тебе гвозди, давай доделаем эти препятствия.
    {Hide("main")}{Hide("grandpa")}
-> END