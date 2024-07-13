-> Intro

VAR meatTaken = ()
VAR trust = 0
VAR speakerName = ""
VAR mainName = ""

EXTERNAL Show(characterName, position, mood)

EXTERNAL Hide(characterName)

== Intro
    ~ mainName = "Мейра"
    Я еду на турнир. Чтобы меня не узнали, я надела старый плащ c и повязку на лицо.
    ~ speakerName = mainName
    Мы уже близко, не волнуйся. Всё будет хорошо.
    ~ speakerName = ""
    Я повторяла эти слова скорее для себя, ведь он совсем не выглядел испуганным. В отличие от меня...
    Вам, наверное, интересно, как я на это решилась и почему мне пришлось скрыть свою внешность. Что ж, устраивайтесь поудобнее, история предвещает быть долгой...
-> Day1

== Day1

= Farm
    Лето закончилось. Я возвращаюсь к бабушке и дедушке на ферму от родителей из Киндвальда. Скоро первый учебный день в университете. Так как я живу загородом на ферме, а университет в ближайшем городе Дражикон, то мне придется каждый день ездить туда. Но это не так страшно, потому что летом на день рождения мне подарили старый, даже местами ржавый пикап. Казалось бы, чему радоваться? Но, всё же, это лучше чем ничего.
    {Show("main", "_1_5", "Fine")}
    Вот я и приехала на ферму.
    Меня встречает дедушка.
    {Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дед"
    Внучка приехала! Иди встречай, хватит уже убираться в этой комнате!
    ~ speakerName = "Бабушка"
    Не ори! Иду я, иду!
    ~ speakerName = "Дед"
    Как доехала? Готова к учебе?
    ~ speakerName = mainName
    Всё хорошо, хоть и было тоскливо покидать родной город. Но тут у меня есть вы и в университете будут друзья, так что я рада приехать сюда. Конечно, я готова... Опять эти лекции, задания, как кру-у-уто...
    {Hide("grandpa")}{Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Дай обниму любимую внучку! Какая ты хорошенькая у меня!
    ~ speakerName = mainName
    Ну, ба, хватит!
    ~ speakerName = "Бабушка"
    Чего хватит? Не могу я теперь обнять свою внучку? Пойдём, отнесём вещи в твою комнату, пора располагаться.
    ~ speakerName = ""
    {Hide("grandma")}{Hide("main")}
    Бабушка как всегда права. Нужно оставить вещи и осваиваться здесь.
-> Room

= Room
    {Show("main", "_1_2", "Fine")}
    Ого! Бабушка постаралась на славу, комната выглядит просто волшебно!
    * [Разобрать чемодан]
    Фух, это было достаточно долго, пора бы пообедать. {Hide("main")}
-> Kitchen

= Kitchen
    ~ speakerName = mainName
    {Show("main", "_1_5", "Fine")}
    Ммм... Как вкусно пахнет!
    {Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Обед готов, садись скорее!
    ~ speakerName = mainName
    Хорошо.
    ~ speakerName = "Бабушка"
    Уже думала, кем хочешь быть после университета?
    ~ speakerName = mainName
    Ага, укротителем драконов!
    ~ speakerName = "Бабушка"
    Опять ты за своё! Девушке нельзя им стать. Забудь об этом и время не будет потрачено зря.
    ~ speakerName = mainName
    Знаю я. Я просто пошутила. Конечно же, я пойду работать по профессии.
    ~ speakerName = "Бабушка"
    То-то же! Ладно, когда я ем, я глух и нем! Кушай.
    {Hide("grandma")}
    ~ speakerName = ""
    На самом деле, я всё равно мечтаю стать укротителем. Изучать, приручать драконов, заботиться о них. Но в чём-то бабушка снова права. Мне и правда никогда не стать укротителем драконов, и это пустая трата времени...
    ~ speakerName = ""
    Еда и правда была восхитительной, теперь бы...
    * [Прогуляться одной]
        Еда и правда была восхитительной, теперь бы прогуляться одной.
        {Show("grandpa", "_4_5", "Fine")}
        ~ speakerName = "Дед"
        Куда уходишь?
        ~ speakerName = mainName
        Хочу прогуляться по лесу.
        ~ speakerName = "Дед"
        Будь осторожна, пожалуйста. Дикие драконы могут быть не дружелюбны.
        ~ speakerName = mainName
        Хорошо. Буду держаться от них подальше.
        ~ speakerName = ""
        {Hide("grandpa")}
        Неспроста дедушка просит меня держаться подальше от диких драконов, ведь он знает как они мне интересны!
        {Show("grandma", "_4_5", "Fine")}
        ~ speakerName = "Бабушка"
        Возьмёшь с собой перекусить? Ты можешь проголодаться.
        ~ speakerName = mainName
        И то верно! Я возьму с собой...
        * * Бутерброд с фасолью
            И то верно! Я возьму с собой бутерброд с фасолью.
            ~ speakerName = ""
            Я поблагодарила бабушку и пошла гулять.
            {Hide("grandma")}{Hide("main")}
            -> WalkAlone
        * * [Котлетки]
            ~ meatTaken = true
            ~ speakerName = mainName
            С макарошками?
            ~ speakerName = "Бабушка"
            Нет, с пюрешкой!
            ~ speakerName = ""
            Я поблагодарила бабушку и пошла гулять.
            {Hide("grandma")}{Hide("main")}
            -> WalkAlone

    * [Прогуляться с дедушкой]
        Еда и правда была восхитительной, теперь бы прогуляться с дедушкой.
        {Show("grandpa", "_4_5", "Fine")}
        Он как раз вроде бы не занят.
        ~ speakerName = mainName
        Дедушка, не хочешь прогуляться со мной?
        ~ speakerName = "Дед"
        Конечно, я буду только рад.
        {Hide("grandpa")}
        ~ speakerName = "Бабушка"
        {Show("grandma", "_4_5", "Fine")}
        Возьмите с собой еду, вдруг проголодаетесь.
        {Hide("grandma")}
        ~ speakerName = "Дед"
        {Show("grandpa", "_4_5", "Fine")}
        Конечно, куда мы без твоей вкусной стряпни. Положи-ка нам с собой котлеток с пюрешкой.
        ~ speakerName = ""
        {Hide("grandpa")}{Hide("main")}
        Мы поблагодарили бабушку за вкусный обед и спокойно пошли гулять по лесу.
        -> WalkGrandpa
        
        
= WalkAlone
    Гуляя по лесу, задумываешься о красоте жизни. Какая же непредсказуемая штука эта судьба - впереди может ожидать крутой поворот, к которому ты можешь быть совсем не готов. Никто не думал, что я буду настолько увлечена драконами, хотя, казалось бы, это обыкновенные животные. Но мне всегда они казались чем-то большим.
    В детстве мне было интересно слушать рассказы дедушки про драконов. Я слушала его завороженно и представляла себя в этих историях. Помню, как однажды просила подарить мне дракончика, чтобы заботиться о нем. Я и сейчас была не против, но теперь понимаю, что это лишь детские мечты. Интересно, встречу ли я драконов в пути? Хотелось бы понаблюдать за ними.
    {Show("main", "_1_5", "Fine")}
    ~ speakerName = mainName
    Что это было?
    Мне точно не послышалось! Звук идет из глубины леса. Может, это дракон!?
    ~ speakerName = ""
    Прислушиваясь к вою, я пыталась понять, откуда он доносится. Когда я определила направление, мое любопытство взяло верх, и я пошла в глубину леса на звук.
    -> Meadow1
    
= Meadow1
    {Show("raven", "_4_5", "Fine")}
    На камне сидел большой ворон, который смотрел на меня. Это было одновременно жутко и забавно.
    ~ speakerName = mainName
    Так это тебя я слышала?
    ~ speakerName = "Ворон"
    Кар-кар-кар.
    ~ speakerName = mainName
    Хм, наверное, из-за эха звук исказился. Прости, я думала, ты дракон...
    ~ speakerName = ""
    {Hide("raven")}
    Собравшись уходить обратно на лесную тропинку, я увидела, как ворон внезапно улетел, каркая мне вслед.
    Обернувшись, я услышала оглушающий вой, который доносился от камня.
    Камень начал двигаться, поворачиваясь в мою сторону. Я поняла, что это вовсе не камень, а самый настоящий дракон!
    {Show("dragon", "_4_5", "Fine")}
    Он смотрел на меня жалобным и в то же время недоверчивым взглядом, показывая свои зубы.
    Мое сердце начало бешено колотиться, я стояла, будто парализованная, смотря на него с восхищением, но в то же время мне было жутко страшно. Я всё ещё не до конца верила, что моя мечта сбылась и одновременно боялась, что он меня сейчас съест.
    Однако, простояв в таком положении минут пять, я осознала, что дракон не собирается нападать на меня. Осторожно осмотрев его издалека, я заметила, что его крыло ранено, а тело покрыто ссадинами и царапинами. Я подумала, чго нельзя тут оставлять, ведь пока он ранен, он вряд ли сможет себя защитить, и надо попытаться забрать его на ферму и вылечить.
    ~ speakerName = mainName
    Не бойся, я не причиню тебе зла.
    ~ speakerName = "Дракон"
    Р-р-р-р-р-р.
    ~ speakerName = mainName
    Может дать тебе еды?
    ~ speakerName = ""
    {meatTaken:
        -> Meat
    - else:
        -> NoMeat
        }
    
= Meat
    * [Дать котлеты]
        Я медленно сняла рюкзак, аккуратным движением достала контейнер с едой и кинула котлеты дракону. Он понюхал их и с удовольствием съел. Дракон посмотрел на меня, вроде, одобрительным взглядом. По крайней мере, мне так показалось.
        [Дракон стал немного доверять тебе. Ты поняла, что драконы очень любят мясо.]
        ~ trust += 1
        -> Dragon
    * [Ничего не давать]
        Лучше оставлю еду себе. Вруг ему такое нельзя?
        -> Dragon
        
= NoMeat
    * [Дать бутерброд с фасолью]
        Я медленно сняла рюкзак, аккуратным движением достала бутерброд и кинула его дракону. Он понюхал бутерброд и растоптал его, показывая своё недовольство. Дракон посмотрел на меня не очень одобрительным взглядом.
        [Ты поняла, что драконы не любят подобную пищу.]
        -> Dragon
    * [Ничего не давать]
        Лучше оставлю еду себе. Вруг ему такое нельзя?
        -> Dragon

= Dragon
    Я решила осторожно подойти к дракону. Опустив голову и вытянув руку, я начала двигаться к нему. Делая маленькие шаги с перерывами, раз за разом становясь ближе, я всё более отчетливо слышала его дыхание.
    Подойдя достаточно близко, я почувствовала, как теплый воздух бил мне в ладонь. Подняв голову, я увидела, как морда дракона касалась моей руки, а глаза смотрели на меня с интересом.
    ~ speakerName = mainName
    Я не причиню тебе зла, пойдём со мной. У нас ты будешь в безопасности.
    ~ speakerName = ""
    В надежде, что дракон пойдет за мной после этих слов, я начала двигаться в сторону фермы. Через некоторое время дракон пошел за мной следом. Я хотела быстрее прийти на ферму и рассказать дедушке о случившемся.
    {Hide("main")}
    {Hide("dragon")}
    -> Night1
    
= Night1
    Когда мы пришли на ферму, дракон остался ждать на краю леса, когда заметил стариков.
    {Show("main", "_1_5", "Fine")}
    Было уже темно, поэтому дедушка с бабушкой ждали меня.
    {Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Ты где была!? Ты время видела!? Мы уже думали, тебя дракон съел!
    {Hide("grandma")}
    ~ speakerName = "Дедушка"
    {Show("grandpa", "_4_5", "Fine")}
    Не заводись, девочка взрослая уже. Я уверен, всё в порядке.
    ~ speakerName = mainName
    Не переживайте, все просто отлично. Я нашла дракона, он меня не съел, он был ранен...
    {Hide("grandpa")}
    ~ speakerName = "Бабушка"
    {Show("grandma", "_4_5", "Fine")}
    Кого!? Ты с дуба рухнула, что ли?! А если его найдут? Держать у себя дикого дракона незаконно! Одурела совсем!?
    {Hide("grandma")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = " Дедушка"
    Хватит трындеть! Ничего не будет, всё будет нормально! Пусть поживет в амбаре, там места много.
    ~ speakerName = ""
    Я никогда не видела такого дедушку. В его мягком голосе появилась твердость, настойчивость и будто немного властность.
    ~ speakerName = mainName
    Спасибо, дедушка!
    {Hide("grandpa")}{Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Помяните мои слова!
    {Hide("grandma")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дедушка"
    Пойдём, проводим его в амбар.
    ~ speakerName = mainName
    Хорошо, сейчас схожу за ним.
    {Hide("grandpa")}
    ~ speakerName = ""
    {Show("dragon", "_4_5", "Fine")}
    Дракон настороженно вышел из леса и пошел за мной к амбару.
    ~ speakerName = mainName
    Заходи, не бойся. Там безопасно, есть еда и можно поспать.
    {Hide("main")}{Hide("dragon")}
    ~ speakerName = ""
    Я говорила с ним так, будто он меня понимает, в чем я сомневаюсь.
    {trust > 0:
        Дракон доверился мне и зашёл в амбар.
    -else:
        Дракон мало мне доверял, поэтому он зашел в амбар неохотно и с опаской.
    }
    -> Barn
    
= WalkGrandpa
    {Show("main", "_1_5", "Fine")}{Show("grandpa", "_4_5", "Fine")}
    На прогулке мы с ним болтали о разном, в том числе и о драконах. Он рассказал мне пару новых историй. Это было восхитительно, я слушала его очень внимательно.
    ~ speakerName = "Дед"
    Ну как тебе истории старика?
    ~ speakerName = mainName
    Ты же знаешь, что мне безумно нравятся истории про драконов!
    ~ speakerName = "Дед"
    Да, знаю. Однако истории - это всего лишь истории. Не путай их с реальностью, держись подальше от диких драконов, хорошо?
    ~ speakerName = mainName
    Хорошо, обещаю тебе.
    ~ speakerName = ""
    Хотя дедушка и просит меня держаться подальше от диких драконов, он знает, как они мне интересны. Помню, даже как-то просила подарить мне дракончика, чтобы я о нём заботилась. Интересно, встретим ли мы драконов в пути? Хотелось бы понаблюдать за ними.
    ~ speakerName = mainName
    Что это было?
    ~ speakerName = "Дед"
    Тебе просто послышалось, я ничего не слышал, пошли дальше.
    ~ speakerName = mainName
    Теперь мне точно не послышалось. Звук идёт из глубины леса. Может, это дракон!?
    ~ speakerName = "Дед"
    Драконы в лесу? Они же потом могут не взлететь из леса, вряд ли это он...
    ~ speakerName = ""
    Не слушая дедушку, я пошла на звук, чтобы утолить своё любопытство. Дедушка, увидев, что я пошла на звук, начал догонять меня.
    ~ speakerName = "Дед"
    {Hide("main")}
    Несносная девчонка. Подожди, {mainName}, пойдём вместе!
    {Hide("grandpa")}
    -> Meadow2
   
= Meadow2
    {Show("main", "_1_5", "Fine")}
    ~ speakerName = ""
    Дедушка провёл нас по тропинке, ведь он знает эти леса, и мы вышли на маленькую лужайку, посреди которой был большой валун, покрытый ветвями деревьев.
    {Show("raven", "_4_5", "Fine")}
    На камне сидел большой ворон, который смотрел на нас.
    ~ speakerName = mainName
    Так это тебя я слышала?
    ~ speakerName = "Ворон"
    Кар-кар-кар.
    ~ speakerName = mainName
    Хм, наверное, из-за эха звук исказился. Прости, я думала, ты дракон...
    {Hide("raven")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дед"
    Я же говорил, что тут нет никаких драконов. Пошли обратно к ферме.
    ~ speakerName = ""
    Собравшись уходить обратно на ферму, я увидела, как ворон внезапно улетел, каркая нам вслед. Обернувшись, я услышала оглушающий вой, который доносился от камня. Камень начал двигаться, поворачиваясь на нас. Я поняла, что это вовсе не камень, а самый настоящий дракон!
    {Hide("grandpa")}{Show("dragon", "_4_5", "Fine")}
    Он смотрел на нас жалобным и в то же время недоверчивым взглядом, показывая свои зубы. Моё сердце начало бешено колотиться, я стояла, будто парализованная, смотря на него с восхищением, но в то же время мне было жутко страшно. Я всё ещё не до конца верила, что моя мечта сбылась и одновременно боялась, что он сейчас съест нас, и всё из-за меня!
    {Hide("dragon")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дед"
    Дыши нормально, не волнуйся. Веди себя спокойно, и он нас не тронет.
    ~ speakerName = ""
    На моё удивление дедушка вёл себя очень спокойно, и я тоже последовала его совету.
    ~ speakerName = mainName
    Спасибо тебе, дедушка, не знаю, что бы я без тебя делала.
    ~ speakerName = "Дед"
    Странно, что он сразу не улетел, увидев нас, скорее всего он сильно ранен.
    ~ speakerName = ""
    Окинув его взглядом, я заметила, что у него и правда ранено крыло, а тело было всё в ссадинах и царапинах. Дедушка был прав.
    Пока мы стояли неподалёку от дракона и наблюдали за ним, он наблюдал за нами и не подпускал нас ближе.
    ~ speakerName = mainName
    Его нельзя тут оставлять! Пока он ранен, он не сможет себя защитить. Надо попытаться забрать его на ферму и вылечить.
    ~ speakerName = "Дед"
    Я думаю, ты права. Поселим его в амбре. Он у нас большой, места должно хватить. А пока доставай мясо, он, похоже, голоден. Только медленно.
    ~ speakerName = mainName
    Хочешь, я дам тебе еды?
    ~ speakerName = ""
    Я медленно сняла рюкзак и аккуратным движением достала контейнер и кинула котлету дракону. Он понюхал её и с удовольствием съел. Дракон посмотрел на меня, вроде, одобрительным взглядом. По крайней мере, мне так показалось.
    ~ speakerName = "Дед"
    А теперь дай и мне одну.
    ~ speakerName = ""
    Я также аккуратно дала контейнер дедушке. Как только он достал котлету, то незамедлительно пошёл к дракону. Подойдя, дедушка протянул ему угощение. Дракон обратил внимание на дедушку и выхватил быстрым движением пасти котлету у него из рук.
    ~ speakerName = "Дед"
    {Hide("grandpa")}{Show("dragon", "_4_5", "Fine")}
    Не бойся, всё хорошо. Мы хорошие, пошли с нами, мы тебе поможем.
    ~ speakerName = "Дракон"
    Р-р-р.
    ~ speakerName = ""
    Дракон будто понял, что говорил дедушка, и пошёл, не думая, за нами на ферму.
    {Hide("main")}{Hide("dragon")}
    -> Night2

= Night2
    Мы уже подходили к ферме, было темно, лишь бабушка стояла и ждала нас с лампой в руке.
    {Show("main", "_1_5", "Fine")}{Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Вы где были!? Вы время видели!? Я думала, вас дракон съел!
    ~ speakerName = mainName
    Ну, вообще, почти так и было. Смотри, кого мы привели.
    {Hide("grandma")}{Show("dragon", "_4_5", "Fine")}
    ~ speakerName = "Дракон"
    Р-р.
    {Hide("dragon")}{Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Мать честная!
    {Hide("grandma")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дед"
    Не заводись, всё будет нормально. Он ранен, поэтому мы решили помочь ему.
    {Hide("grandpa")}{Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Вы с дуба рухнули, что ли!? А если его найдут? Держать у себя дикого дракона незаконно! Одурели совсем!?
    {Hide("grandma")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дедушка"
    Хватит трындеть! Ничего не будет! Пусть поживет в амбаре, там места много.
    {Hide("grandpa")}
    ~ speakerName = ""
    Я никогда не видела такого дедушку. В его мягком голосе появилась твёрдость, настойчивость и будто немного властность.
    ~ speakerName = mainName
    Да! Мы только вылечим его и всё, не волнуйся.
    {Show("grandma", "_4_5", "Fine")}
    ~ speakerName = "Бабушка"
    Помяните мои слова!
    {Hide("grandma")}{Show("grandpa", "_4_5", "Fine")}
    ~ speakerName = "Дедушка"
    Пошли, проводим его в амбар.
    {Hide("grandpa")}
    ~ speakerName = ""
    Дракон пошёл за нами по пятам, не отставая.
    {Show("dragon", "_4_5", "Fine")}
    ~ speakerName = mainName
    Заходи, не бойся. Там безопасно, есть еда, можно поспать.
    ~ speakerName = ""
    {Hide("main")}{Hide("dragon")}
    Я говорила с ним так, будто он меня понимает, в чем я сомневаюсь. Дракон заходил в амбар с опаской, оглядываясь по сторонам, но более-менее уверенно.
    -> Barn
    
= Barn
    ~ speakerName = mainName
    {Show("main", "_1_5", "Fine")}{Show("dragon", "_4_5", "Fine")}
    Надо дать тебе имя, раз ты пока что у нас.
    Я назову тебя...

-> END