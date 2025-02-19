-> Intro

VAR meatTaken = ()
VAR trust = 0
VAR speakerName = "Эльвира"
VAR mainName = "Эльвира"


== Intro
    [Ввести имя главного героя]
    
    Я еду на турнир. Чтобы меня не узнали, я надела старый плащ c и повязку на лицо.
    {mainName}: Мы уже близко, не волнуйся. Всё будет хорошо.
    Я повторяла эти слова скорее для себя, ведь дракон совсем не выглядел испуганным. В отличие от меня...
    
    Вам, наверное, интересно, как я на это решилась и почему мне пришлось скрыть свою внешность. Что ж, устраивайтесь поудобнее, история предвещает быть долгой...
-> Day1

== Day1

= Farm
    Лето закончилось. Я возвращаюсь к бабушке и дедушке на ферму от родителей из Киндвальда. Скоро первый учебный день в университете. Так как я живу загородом на ферме, а университет в ближайшем городе Дражикон, то мне придется каждый день ездить туда. Но это не так страшно, потому что летом на день рождения мне подарили старый, даже местами ржавый пикап. Казалось бы, чему радоваться? Но, всё же, это лучше чем ничего.
    Вот я и приехала на ферму.
    Меня встречает дедушка.
    Дед: Внучка приехала! Иди встречай, хватит уже убираться в этой комнате!
    Бабушка: Не ори! Иду я, иду!
    Дед: Как доехала? Готова к учебе?
    {mainName}: Всё хорошо, хоть и было тоскливо покидать родной город. Но тут у меня есть вы и в университете будут друзья, так что я рада приехать сюда. Конечно, я готова... опять эти лекции, задания, как кру-у-уто...
    Бабушка: Дай обниму любимую внучку! Какая ты хорошенькая у меня!
    {mainName}: Ну, ба, хватит!
    Бабушка: Чего хватит? Не могу я теперь обнять свою внучку? Пойдём, отнесём вещи в твою комнату, пора располагаться.
    Бабушка как всегда права. Нужно оставить вещи и осваиваться здесь.
-> Room

= Room
    Ого! Бабушка постаралась на славу, комната выглядит просто волшебно!
    * [Разобрать чемодан]
    {mainName}: Фух, это было достаточно долго, пора бы пообедать.
-> Kitchen

= Kitchen
    {mainName}: Ммм... Чем это таким вкусным пахнет?
    Бабушка: Обед готов, садись скорее!
    {mainName}: Хорошо.
    Бабушка: Уже думала, кем хочешь быть после университета?
    {mainName}: Ага, укротителем драконов!
    Бабушка: Опять ты за своё! Девушке нельзя им стать. Забудь об этом и время не будет потрачено зря.
    {mainName}: Знаю я. Я просто пошутила. Конечно же, я пойду работать по профессии.
    На самом деле, я всё равно мечтаю стать укротителем. Изучать, приручать драконов, заботиться о них. Но в чём-то бабушка снова права. Мне и правда никогда не стать укротителем драконов, и это пустая трата времени.
    Бабушка: Ладно, когда я ем, я глух и нем! Кушай.
    {mainName}: Еда и правда была восхитительной, теперь бы...
    * [Прогуляться одной]
        Дед: Куда уходишь?
        {mainName}: Хочу прогуляться по лесу.
        Дед: Будь осторожна, пожалуйста. Дикие драконы могут быть не дружелюбны.
        {mainName}: Хорошо. Буду держаться от них подальше.
        Неспроста дедушка просит меня держаться подальше от диких драконов, ведь он знает как они мне интересны.
        Бабушка: Возьмёшь с собой перекусить? Ты можешь проголодаться.
        {mainName}: И то верно. Я возьму с собой...
        * * [Бутерброд с фасолью]
            Я поблагодарила бабушку за вкусный обед и отправилась в лес.
            -> WalkAlone
        * * [Жареную свинину]
            ~ meatTaken = true
            Я поблагодарила бабушку за вкусный обед и отправилась в лес.
            -> WalkAlone

    * [Прогуляться с дедушкой]
        Дедушка как раз в последние дни ничего не делает.
        {mainName}: Дедушка, не хочешь прогуляться со мной?
        Дед: Конечно, я буду только рад.
        Бабка: Возьмите с собой еду, вдруг проголодаетесь.
        Дед: Конечно, куда мы без твоей вкусной стряпни. Положи-ка нам с собой свининки.
        Мы поблагодарили бабушку за вкусный обед и спокойно пошли гулять по лесу.
        -> WalkGrandpa
        
        
= WalkAlone
    Гуляя по лесу, задумываешься о красоте жизни. Какая же непредсказуемая штука эта судьба — впереди может ожидать крутой поворот, к которому ты можешь быть совсем не готов. Никто не думал, что я буду настолько увлечена драконами, хотя, казалось бы, это обыкновенные животные. Но мне всегда они казались чем-то большим. В детстве мне было интересно слушать рассказы дедушки про драконов. Я слушала его завороженно и представляла себя в этих историях. Помню, как однажды просила подарить мне дракончика, чтобы заботиться о нем. Я и сейчас была не против, но теперь понимаю, что это лишь детские мечты. Интересно, встречу ли я драконов в пути? Хотелось бы понаблюдать за ними.
    {mainName}: Что это было?
    {mainName}: Мне точно не послышалось. Звук идет из глубины леса. Может, это дракон!?
    Прислушиваясь к вою, я пыталась понять, откуда он доносится. Когда я определила направление, мое любопытство взяло верх, и я пошла в глубину леса на звук.
    -> Meadow1
    
= Meadow1
    На камне сидел большой ворон, который смотрел на меня. Это было одновременно жутко и забавно.
    {mainName}: Так это тебя я слышала?
    Ворон: Кар-кар-кар.
    {mainName}: Хм, наверное, из-за эха звук исказился. Прости, я думала, ты дракон...
    Собравшись уходить обратно на лесную тропинку, я увидела, как ворон внезапно улетел, каркая мне вслед.
    Обернувшись, я услышала оглушающий вой, который доносился от камня.
    Камень начал двигаться, поворачиваясь в мою сторону. Я поняла, что это вовсе не камень, а самый настоящий дракон!
    Он смотрел на меня жалобным и в то же время недоверчивым взглядом, показывая свои зубы.
    Мое сердце начало бешено колотиться, я стояла, будто парализованная, смотря на него с восхищением, но в то же время мне было жутко страшно. Я всё ещё не до конца верила, что моя мечта сбылась и одновременно боялась, что он меня сейчас съест.
    Однако, простояв в таком положении минут пять, я осознала, что дракон не собирается нападать на меня. Осторожно осмотрев его издалека, я заметила, что его крыло ранено, а тело покрыто ссадинами и царапинами. Я подумала, чго нельзя тут оставлять, ведь пока он ранен, он вряд ли сможет себя защитить, и надо попытаться забрать его на ферму и вылечить.
    {mainName}: Не бойся, я не причиню тебе зла.
    Дракон: Р-р-р-р-р-р.
    {mainName}: Может дать тебе еды?
    {meatTaken:
        -> Meat
    - else:
        -> NoMeat
        }
    
= Meat
    * [Дать кусок жареной свинины]
        Я медленно сняла рюкзак, аккуратным движением достала кусок жареной свинины и кинула его дракону. Он понюхал мясо и с удовольствием съел его. Дракон посмотрел на меня, вроде, одобрительным взглядом. По крайней мере, мне так показалось.
        [Дракон стал немного доверять тебе. Ты поняла, что драконы очень любят мясо.]
        ~ trust += 1
        -> Dragon
    * [Ничего не давать]
        Лучше оставлю еду себе. Вдруг драконам вообще нельзя жаренное?
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
    {mainName}: — Я не причиню тебе зла, пойдём со мной. Ты будешь в безопасности.
    В надежде, что дракон пойдет за мной после этих слов, я начала двигаться в сторону фермы. Через некоторое время дракон пошел за мной следом. Я хотела быстрее прийти на ферму и рассказать дедушке о случившемся.
    -> Night1
    
= Night1
    Когда мы пришли на ферму, дракон остался ждать на краю леса, когда заметил стариков.
    Было уже темно, поэтому дедушка с бабушкой ждали меня.
    Бабушка: Ты где была!? Ты время видела!? Мы уже думали, тебя дракон съел!
    Дедушка: Не заводись, девочка взрослая уже. Я уверен, все в порядке.
    {mainName}: Не переживайте, все просто отлично. Я нашла дракона, он меня не съел, он был ранен...
    Бабушка: Кого!? Ты с дуба рухнула, что ли?! А если его найдут? Держать у себя дикого дракона незаконно!
    Дедушка: Хватит трындеть! Ничего не будет, всё будет нормально! Пусть поживет в амбаре, там места много.
    Я никогда не видела такого дедушку. В его мягком голосе появилась твердость, настойчивость и будто немного властность.
    {mainName}: Спасибо, дедушка!
    Бабушка: Помяните мои слова!
    Дедушка: Пошли, проводим его в амбар.
    {mainName}: Хорошо, сейчас схожу за ним.
    Дракон настороженно вышел из леса и пошел за мной к амбару.
    {mainName}: Заходи, не бойся. Там безопасно, есть еда и можно поспать.
    Я говорила с ним так, будто он меня понимает, в чем я сомневаюсь.
    {trust > 0:
        Дракон доверился мне и зашёл в амбар.
    -else:
        Дракон мало мне доверял, поэтому он зашел в амбар неохотно и с опаской.
        }
    -> Barn
    
= WalkGrandpa
   На прогулке мы с ним болтали о разном, в том числе и о драконах. Он рассказал мне пару новых историй. Это было восхитительно, я слушала его очень внимательно.
   Дед: Ну как тебе истории старика?
   {mainName}: Ты же знаешь, что мне безумно нравятся истории про драконов.
   Дед: Да, знаю. Однако истории — это всего лишь истории. Не путай их с реальностью, держись подальше от диких драконов, хорошо?
   {mainName}: Хорошо, обещаю тебе.
   Хотя дедушка и просит меня держаться подальше от диких драконов, он знает, как они мне интересны. Помню, даже как-то просила подарить мне дракончика, чтобы я о нём заботилась. Интересно, встретим ли мы драконов в пути? Хотелось бы понаблюдать за ними.
   {mainName}: Что это было?
   Дед: Тебе просто послышалось, я ничего не слышал, пошли дальше.
   {mainName}: Теперь мне точно не послышалось. Звук идёт из глубины леса. Может, это дракон!?
   Дед: Драконы в лесу? Они же потом могут не взлететь из леса, вряд ли это он...
   Не слушая дедушку, я пошла на звук, чтобы утолить своё любопытство. Дедушка, увидев, что я пошла на звук, начал догонять меня, ведь он не мог отпустить меня одну, вдруг там опасно.
   Дед: Несносная девчонка. Подожди, {mainName}, пойдём вместе!
   -> Meadow2
   
= Meadow2
    Дедушка провёл нас по тропинке, ведь он знает эти леса, и мы вышли на маленькую лужайку, посреди которой был большой валун, покрытый ветвями деревьев. На камне сидел большой ворон, который смотрел на нас.
    {mainName}: Так это тебя я слышала?
    Ворон: Кар-кар-кар.
    {mainName}: Хм, наверное, из-за эха звук исказился. Прости, я думала, ты дракон...
    Дед: Я же говорил, что тут нет никаких драконов. Пошли обратно к ферме.
    Собравшись уходить обратно на ферму, я увидела, как ворон внезапно улетел, каркая нам вслед. Обернувшись, я услышала оглушающий вой, который доносился от камня. Камень начал двигаться, поворачиваясь на нас. Я поняла, что это вовсе не камень, а самый настоящий дракон!
    Он смотрел на нас жалобным и в то же время недоверчивым взглядом, показывая свои зубы. Моё сердце начало бешено колотиться, я стояла, будто парализованная, смотря на него с восхищением, но в то же время мне было жутко страшно. Я всё ещё не до конца верила, что моя мечта сбылась и одновременно боялась, что он сейчас съест нас, и всё из-за меня!
    Дед: Дыши нормально, не волнуйся. Веди себя спокойно, и он нас не тронет.
    На моё удивление дедушка вёл себя очень спокойно, и я тоже последовала его совету.
    {mainName}: Спасибо тебе, дедушка, не знаю, что бы я без тебя делала.
    Дед: Странно, что он сразу не улетел, увидев нас, скорее всего он сильно ранен.
    Окинув его взглядом, я заметила, что у него и правда ранено крыло, а тело было всё в ссадинах и царапинах. Дедушка был прав.
    Пока мы стояли неподалёку от дракона и наблюдали за ним, он наблюдал за нами и не подпускал нас ближе.
    {mainName}: Его нельзя тут оставлять. Пока он ранен, он не сможет себя защитить. Надо попытаться забрать его на ферму и вылечить.
    Дед: Я думаю, ты права. Поселим его в амбре. Он у нас большой, места должно хватить. А пока доставай мясо, он, похоже, голоден. Только медленно.
    {mainName}: Хочешь, я дам тебе еды?
    Я медленно сняла рюкзак и аккуратным движением достала кусок жареной свинины и кинула его дракону. Он понюхал мясо и с удовольствием съел его. Он посмотрел на меня, вроде, одобрительным взглядом. По крайней мере, мне так показалось.
    Дед: А теперь дай мне мой кусочек.
    Я также аккуратно достала кусочек жареной свинины и дала его дедушке. Как только я передала ему этот кусочек, он незамедлительно пошёл к дракону. Подойдя к дракону, дедушка протянул ему кусочек мяса. Дракон обратил внимание на дедушку и выхватил быстрым движением пасти кусочек мяса у него из рук.
    Дед: Не бойся, всё хорошо. Мы хорошие, пошли с нами, мы тебе поможем.
    Дракон: Р-р-р.
    Он будто понял, что говорил дедушка, и пошёл, не думая, за нами на ферму.
    -> Night2

= Night2
    Мы уже подходили к ферме, было темно, лишь бабушка стояла и ждала нас с лампой в руке.
    Бабушка: Вы где были!? Вы время видели!? Я думала, вас дракон съел!
    {mainName}: Ну, вообще, почти так и было. Смотри, кого мы привели.
    Дракон: Р-р.
    Бабушка: Мать честная!
    Дед: Не заводись, всё будет нормально. Он ранен, поэтому мы решили помочь ему.
    Бабушка: Вы с дуба рухнули, что ли!? А если его найдут? Держать у себя дикого дракона незаконно!
    Дедушка: Хватит трындеть! Ничего не будет! Пусть поживет в амбаре, там места много.
    Я никогда не видела такого дедушку. В его мягком голосе появилась твёрдость, настойчивость и будто немного властность.
    {mainName}: Да! Мы только вылечим его и всё, не волнуйся.
    Бабушка: Помяните мои слова!
    Дедушка: Пошли, проводим его в амбар.
    Дракон пошёл за нами по пятам, не отставая.
    {mainName}: Заходи, не бойся. Там безопасно, есть еда, можно поспать.
    Я говорила с ним так, будто он меня понимает, в чем я сомневаюсь. Дракон заходил в амбар с опаской, оглядываясь по сторонам, но более-менее уверенно.
    -> Barn
    
= Barn
    {mainName}: Надо дать тебе имя, раз ты пока что у нас.
    {mainName}: Я назову тебя...
    [Ввести имя дракона]

-> END