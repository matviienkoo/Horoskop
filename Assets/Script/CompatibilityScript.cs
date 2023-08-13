using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompatibilityScript : MonoBehaviour
{
    private int Friend_Zodiac;
    private int Your_Zodiac;
    private float Timer;

    [Header("Выбор зодиака")]
    public Dropdown Dropdown_Your_Zodiac;
    public Dropdown Dropdown_Friend_Zodiac;

    [Header("Общие данные о Зодиаке")]
    public Text PercentCompatibility_Text;
    public Text BasicCompatibility_Text;

    [Header("Картинка твоего зодиака")]
    public Image YourZodiac_Img_Scene;
    public Image YourZodiac_Img_Rezult;
    public Text Your_Zodiac_Text;

    [Header("Картинка зодиака друга")]
    public Image FriendZodiac_Img_Scene;
    public Image FriendZodiac_Img_Rezult;
    public Text Friend_Zodiac_text;

    [Header("Спрайты зодиака")]
    public Sprite Oven;
    public Sprite Telec;
    public Sprite Blizneci;
    public Sprite Rak;
    public Sprite Lev;
    public Sprite Deva;
    public Sprite Vesy;
    public Sprite Skorpion;
    public Sprite Strelec;
    public Sprite Kozeroh;
    public Sprite Vodoley;
    public Sprite Ryby;

    [Header("Панель результата совместимости")]
    public GameObject RezultCompatibility;

    [Header("Панели для перехода")]
    public GameObject Transtion_Object;
    public Animation Transtion_Animation;
    public string String_Transtion;
    public bool Bool_Transtion;

    private void Start() 
    {
        Dropdown_Your_Zodiac.onValueChanged.AddListener(delegate {
        myDropdownValueChangedHandler(Dropdown_Your_Zodiac);
        });

        Dropdown_Friend_Zodiac.onValueChanged.AddListener(delegate {
        myDropdownValueChangedHandlerr(Dropdown_Friend_Zodiac);
        });
    }

    // Изменить выбор твоего зодиака
    private void myDropdownValueChangedHandler(Dropdown target) 
    {
        Your_Zodiac = Dropdown_Your_Zodiac.value;
        UpdateData();
        ImgUpdate();
    }

    // Изменить выбор зодиака друга
    private void myDropdownValueChangedHandlerr(Dropdown target) 
    {
        Friend_Zodiac = Dropdown_Friend_Zodiac.value;
        UpdateData();
        ImgUpdate();
    }

    // Результат Совместимости
    public void CompatibilityRezult ()
    {
        Transtion_Object.SetActive(true);
        Transtion_Animation.Play();

        String_Transtion = "Compatibility Rezult";
        Bool_Transtion = true;
    }

    // Вернуться Назад
    public void CompatibilityReturn ()
    {
        Transtion_Object.SetActive(true);
        Transtion_Animation.Play();

        String_Transtion = "Compatibility Return";
        Bool_Transtion = true;
    }

    private void Update ()
    {
        if (Bool_Transtion == true){
        Timer += Time.deltaTime;
        if (Timer >= 0.50)
        {
            if (String_Transtion == "Compatibility Rezult")
            {
                RezultCompatibility.SetActive(true);

                UpdateData();
                ImgUpdate();
            }

            if (String_Transtion == "Compatibility Return")
            {
                RezultCompatibility.SetActive(false);

                UpdateData();
                ImgUpdate();
            }
        }

        if (Timer >= 1)
        {
            Bool_Transtion = false;

            Transtion_Object.SetActive(false);
            Timer = 0;
        }
        }
    }

    // Обновить текстовые данные
    private void UpdateData ()
    {
        // ОВЕН
        if (Your_Zodiac == 0)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 91%.";
            BasicCompatibility_Text.text = "Они одинаковые, но есть одно но: каждый из них настолько ярко проявляет свои гендерные роли, что они кажутся совершенно разными.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 81%.";
            BasicCompatibility_Text.text = "Она сможет оставаться яркой и активной рядом с ним, он – медлительным, но настойчивым. И когда ее внешний напор встречается с его внутренним, начинается молчаливая схватка двух упрямцев. Потом они влюбляются друг в друга и бороться становится еще интереснее.";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 72%.";
            BasicCompatibility_Text.text = "Она огненная, он воздушный. Он может дать ей разгореться еще сильнее или наоборот, затушить ее пламя. Она его, конечно, не обожжет, но точно останется надолго в его памяти.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 81%. ";
            BasicCompatibility_Text.text = "Она – яркая и строптивая, он – нерешительный и сентиментальный. Кажется, они друг для друга именно то, что нужно. Конечно, ссор не избежать – но мириться они будут так сладко, что полюбят эти ссоры.";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 97%.";
            BasicCompatibility_Text.text = "Оба они приналежат к стихии Огня: яркие и энергичные, вспыхивают быстро и так же быстро сгорают.";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 84%.";
            BasicCompatibility_Text.text = "Если она — это пожар, то он — портативный огнетушитель. Удобный, практичный, своевременный.";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Возможно, это нестандартное распределение ролей — настойчивая женщина и податливый мужчина — но им самим такое положение вещей очень даже нравится.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 76%.";
            BasicCompatibility_Text.text = "Овен принадлежит к разряду тех людей, кто не привык долго ждать и берет инициативу в свои руки, а Скорпион из тех, кто любит, когда овен проявляет себя четко и самостоятельно.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "В вашем зодиаке, конечно, больше огня, но и он не промах. Но сможет ли этот яркий собственник примириться с исключительным свободолюбием Стрельца?";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Овен поражает своим напором, Козерог — своей упорностью. Такие похожие слова, и такой разный смысл.";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Яркая и напористая, он — непредсказуемый и свободолюбивый. Сумеет ли она удержать его? Сумеет ли он оказать ей достойное сопротивление, но не переборщить?";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 87%.";
            BasicCompatibility_Text.text = "Они очень разные. Она — яркость и напор, он — мягкость и бездействие. Возможно, она сумеет зарядить его.";
            }
        }

        // ТЕЛЕЦ
        if (Your_Zodiac == 1)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 72%.";
            BasicCompatibility_Text.text = "Она — мягкая, но упрямая, он — строптивый, порывистый, страстный. Он вполне может показать ей, какая энергия прячется внутри нее самой. Но нужно ли ей это?";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 87%.";
            BasicCompatibility_Text.text = "Они стоят друг друга. Наконец-то у каждого их них нашелся достойный друг. Или соперник?";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 73%.";
            BasicCompatibility_Text.text = "Она – приземленная и очень практичная, он – легкий и ветренный. Сумеет ли он надолго задержаться рядом с ней?";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Женщина-Телец и мужчина-Рак совершенно точно сумеют создать прочные и долгие отношения, ведь у них так много точек соприкосновения.";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 88%.";
            BasicCompatibility_Text.text = "Их отношения — это союз земной невозмутимости и огненной страсти. Хотя, постойте — до союза там далеко.";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Они так похожи. Оба настроены на длительные и честные отношения. Не будет ли им скучно друг с другом?";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Она — земная и практичная, он — возвышенный идеалист. Сумеет ли она «спустить его на землю» или он заставит ее сбросить груз земных забот?";
            }

            //скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 98%.";
            BasicCompatibility_Text.text = "Они представляют собой противоположности. Она не любит громких слов и яркой страсти, он же, напротив, живет только этим. Смогут ли эти двое найти что-то общее?";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 81%.";
            BasicCompatibility_Text.text = "Она — приземленная, спокойная и рассудительная. Он — оптимистичный, неугомонный. Что они смогут друг другу дать?";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 89%.";
            BasicCompatibility_Text.text = "Они подходят друг другу почти так же, как женщина-Козерог и мужчина-Телец.";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Она — земная, стабильная, любит комфорт и удовольствия. Он — неземной, нестабильный, и на комфорт ему плевать.";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 91%.";
            BasicCompatibility_Text.text = "Они неплохо подходят друг другу. Она — приземленная и заботливая, он — отстраненный и чувствительный.";
            }
        }

        // БЛИЗНЕЦЫ
        if (Your_Zodiac == 2)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Они составят интересную пару: она — непостоянная и ускользающая, он — страстный и импульсивный. Сумеет ли он ее удержать?";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 73%.";
            BasicCompatibility_Text.text = "Она — легкая и непостоянная, он — сама стабильность и постоянство. Смогут ли они вместе достичь гармонии?";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 84%.";
            BasicCompatibility_Text.text = "Оба они — воздушны, легкие, любящие общение и развлечения. Кажется, они сумеют найти общий язык.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 67%.";
            BasicCompatibility_Text.text = "Женщина-Близнецы – воздушная, переменчивая. Мужчина-Рак – застенчивый, внутренне противоречивый. Она сможет раскрепостить его, а он обеспечит ей нежность и покой.";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 81%.";
            BasicCompatibility_Text.text = "Она — живая и непосредственная, он — яркий и очень честолюбивый. Сможет ли она увлечься им?";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Женщина-Близнецы отличается воздушностью, а мужчина-Дева — наоборот, практичностью и приземленностью. Найдут ли они о чем поговорить?";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 89%.";
            BasicCompatibility_Text.text = "Они оба — воздушные, любят общение и друг друга. Особенно друг друга.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Их различие в том, что она пытается не драматизировать ни при каких обстоятельствах, а он — гуру драматизации.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 98%.";
            BasicCompatibility_Text.text = "Это две противоположности. Которые, как известно, притягиваются. Со страшной силой.";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Она – легка, несколько поверхностная, он – строгий, даже суровый. Кажется, сложно придумать более разных персонажей. Но они встретились и даже захотели быть вместе. Почему?";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Они очень похожи. Оба принадлежат к стихии Воздуха, отсюда и глубинное взаимопонимание.";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Женщина-Близнецы и мужчина-Рыбы вполне могут составить счастье друг друга.";
            }
        }

        // РАК
        if (Your_Zodiac == 3)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 91%.";
            BasicCompatibility_Text.text = "Она — нежная, неуловимая, смешливая, скромная и сексуальная одновременно. Он — сильный, смелый, активный — огненный! Теперь понимаете, почему они мечтают друг о друге?";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Кажется, они созданы друг для друга: она — нежная и такая семейная, он — чрезвычайно заботливый и спокойный.";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 77%.";
            BasicCompatibility_Text.text = "Она — нежная и осторожная, он — весельчак и повеса. Он точно ее очарует.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Когда они встречаются, им кажется, что они нашли друг друга. Возможно, это действительно так.";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Это люди разных стихий, разного склада. Она — мягкая, нежная, пленительная. Он — царственный и важный. Похоже на Татьяну и Онегина — остается надеяться, что их отношения все же не обречены.";  
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 84%.";
            BasicCompatibility_Text.text = "Она — идеальная жена, он — лучший муж, по мнению многих. Слишком идеально, не так ли?";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 94%.";
            BasicCompatibility_Text.text = "Они оба любят любовь, но немного по-разному.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 91%.";
            BasicCompatibility_Text.text = "Она – сама нежность, он – чистая страсть. Где та золотая середина, на которой они наконец встретятся и захотят поделиться друг с другом тем, что из себя представляют?";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Рак и Стрелец — знаки трудносовместимые: там, где Рак хочет осесть и остепениться, у Стрельца только начинается веселая кочевая жизнь.";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 96%.";
            BasicCompatibility_Text.text = "Они полные противоположности. Любят друг друга, но бегут друг от друга.";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 84%.";
            BasicCompatibility_Text.text = "Она мягкая и нежная, он порывистый, «воздушный». Найдут ли они точки соприкосновения?";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 90%.";
            BasicCompatibility_Text.text = "Они оба принадлежат к Водной стихии, так что понимают, чего хотят — они сами и те, кого они любят.";
            }
        }

        // ЛЕВ
        if (Your_Zodiac == 4)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 99%.";
            BasicCompatibility_Text.text = "Они оба знают, чего хотят. Поэтому долго не раздумывают, быть им вместе или нет.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 91%.";
            BasicCompatibility_Text.text = "На расстоянии они нравятся друг другу больше, чем вблизи.";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 68%.";
            BasicCompatibility_Text.text = "Эта пара может похвастаться тем, что вместе они найдут выход из любой ситуации: благодаря неиссякаемому энтузиазму женщины-Льва и обширным связям мужчины-Близнеца.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 71%.";
            BasicCompatibility_Text.text = "Это союз воды и огня: будет чувственно и горячо.";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 87%.";
            BasicCompatibility_Text.text = "Это встреча двух царей — точнее, царя и царицы. Скорее всего, они так и не сумеют определить, кто из них победил в соревновании на величественность, но кое-что они все же для себя выяснят.";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 86%.";
            BasicCompatibility_Text.text = "Она — страстная, он — холодный. Вероятно, их притягивает друг к другу именно в силу такой противоположности характеров.";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 79%.";
            BasicCompatibility_Text.text = "Они достаточно разные, чтобы привлечь внимание друг друга — и достаточно похожие, чтобы продолжить знакомство.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 98%.";
            BasicCompatibility_Text.text = "Они оба — огненные, порывистые, сложные. Им будет страшно интересно вместе.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 90%.";
            BasicCompatibility_Text.text = "Они очень похожи. Яркие, самодостаточные — особенно она.";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 76%.";
            BasicCompatibility_Text.text = "Она такая жаркая, а он такой холодный. Они точно полюбят друг друга.";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 97%.";
            BasicCompatibility_Text.text = "Она – полная эгоистка, он же – законченный альтруист. Как думаете, кто в этой паре будет центром Вселенной?";
            }


            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Она — яркая и страстная, он — нежный и робкий. Они должны неплохо друг другу подойти.";
            }
        }

        // ДЕВА
        if (Your_Zodiac == 5)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 71%.";
            BasicCompatibility_Text.text = "Она — земная, он — огненный. Когда они соединяются, они могут свернуть горы.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 69%.";
            BasicCompatibility_Text.text = "Они оба земные, практичные. Им будет комфортно друг с другом. Но интересно ли?";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 75%.";
            BasicCompatibility_Text.text = "Они оба находятся под управлением Меркурия. Ее планета наделяет здоровой практичностью и скептицизмом, его – высокой контактностью и легкостью характера. Смогут ли они чем-то поделиться друг с другом?";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 81%.";
            BasicCompatibility_Text.text = "Она — практичная, он — ранимый. Думается, они отлично подойдут друг другу.";            
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 73%.";
            BasicCompatibility_Text.text = "Ей может быть непонятна его страсть к славе и влиянию. Он же не разделит ее скромности.";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 75%.";
            BasicCompatibility_Text.text = "Они так похожи, что просто не могут не заметить друг друга. Но смогут ли они по-настоящему заинтересоваться друг другом – вот это вопрос.";           
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 74%.";
            BasicCompatibility_Text.text = "Она любит порядок, он — гармонию. Посмотрим, насколько совместимы эти понятия.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 98%.";
            BasicCompatibility_Text.text = "Она – практична и порядочна. Он – горяч и хладнокровен одновременно. Их встреча похожа на встречу удава и мышки – очень хитрой мышки.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 72%.";
            BasicCompatibility_Text.text = "Она совсем не любит спешить, он же мчится на всех парусах, чтобы успеть. Совпадут ли когда-нибудь их ритмы?";           
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 61%.";
            BasicCompatibility_Text.text = "Они оба – воплощение практичности и стабильности. Не станет ли им скучно друг с другом?";         
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 72%.";
            BasicCompatibility_Text.text = "Она — та, которая твердо стоит на ногах, он – вечно витает в облаках. Удастся ли ей спустить его на землю?";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 67%.";
            BasicCompatibility_Text.text = "Она – сама рациональность и практичность. Он всегда расслаблен и имеет богатое воображение. Она привыкла к четкому графику, ему же по душе спонтанность и отсутствие рамок. Найдут ли они точки соприкосновения?"; 
            }
        }

        // ВЕСЫ
        if (Your_Zodiac == 6)
        {
            //овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Она – сама мягкость и дипломатичность, он же состоит из желания и нетерпения. Кажется, они созданы друг для друга. Или…";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Они так похожи: оба стремятся к гармонии и любви.";      
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Это союз двух легких, воздушных людей. Иногда, впрочем, им будет просто необходимо приземлиться.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 78%.";
            BasicCompatibility_Text.text = "Отношения между женщиной-Весы и мужчиной-Раком будут нежными и романтичными. Но крепкими ли?";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 89%.";
            BasicCompatibility_Text.text = "Ей нравится его огонь, ему — ее воздушность.";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 85%.";
            BasicCompatibility_Text.text = "Она — мягкая и романтичная, он — практичный, устойчивый, серьезный.";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 91%.";
            BasicCompatibility_Text.text = "Пожалуй, это самый дипломатичный союз из всех возможных.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 64%.";
            BasicCompatibility_Text.text = "Она специалист по внешней гармонии, он — по внутренней дисгармонии. Кажется, им нужно многое обсудить.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 88%.";
            BasicCompatibility_Text.text = "Она – романтичная, он – оптимистичный. Она сглаживает острые углы, он попросту не обращает на них внимания.";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Она — легкая и приятная, он — настоящий мужчина. Кажется, они нашли друг друга.";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 96%.";
            BasicCompatibility_Text.text = "Они оба не любят долгих выяснений отношений, а любят когда все легко, просто и хорошо.";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 81%.";
            BasicCompatibility_Text.text = "Женщина-Весы и мужчина-Рыбы вместе составят красивую пару, она — нежная и бесконфликтная, он — тонкий и понимающий.";
            }
        }

        // СКОРПИОН
        if (Your_Zodiac == 7)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 72%.";
            BasicCompatibility_Text.text = "Они оба страстные и знают, чего хотят. Главное, чтобы они хотели одного и того же.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 60%.";
            BasicCompatibility_Text.text = "Она сама страсть, а он – покой. Она мятеж, он – безмятежность. Они действительно нуждаются друг в друге, но понимают это далеко не сразу.";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 58%.";
            BasicCompatibility_Text.text = "Они довольно разные. Он вряд ли разделит ее тягу к эмоционально насыщенной жизни.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 89%.";
            BasicCompatibility_Text.text = "Они будут понимать друг друга с полуслова, потому что оба тонкие, чувственные, нежные и страстные. Они по-настоящему любят любовь.";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Они оба яркие и страстные — не много ли огня на двоих?";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 76%.";
            BasicCompatibility_Text.text = "Она — самая страстная представительница зодиака, он — самый прагматичный. Что между ними общего?";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 77%.";
            BasicCompatibility_Text.text = "Женщина-Скорпион – пожалуй, самая страстная из всех, кто встречался на его пути. Он – робкий, застенчивый, дипломатичный. Сумеет ли она его раскрепостить и раскрыть так, чтобы ей самой стало невыносимо интересно?..";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 94%.";
            BasicCompatibility_Text.text = "Это два сгустка кипучей энергии, страсти, завышенных амбиций и глубокой чувствительности. Оказавшись рядом, они вряд ли смогут отказаться от искушения попробовать друг друга на вкус.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Она — любительница глубоких и интенсивных эмоций, он же предпочитает свободу и легкость. Сумеет ли она завладеть его сердцем?";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Женщина-Скорпион — самая страстная из всех зодиакальных дам. Мужчина-Козерог — самый закрытый и строгий мужчина, которых вы когда либо встречали. Сумеет ли она раскрыть его? Под силу ли ему удержать ее?";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 88%.";
            BasicCompatibility_Text.text = "Женщина-Скорпион и мужчина-Водолей сумеют поладить друг с другом. Оба они целеустремленные, бесшабашны и ценят внутреннюю свободу личности."; 
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 97%.";
            BasicCompatibility_Text.text = "Они оба — чувственные, страстные и нежные. Романтики между этими двумя будет море.";
            }
        }

        // СТРЕЛЕЦ
        if (Your_Zodiac == 8)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 84%.";
            BasicCompatibility_Text.text = "Они оба яркие, огненные — довольно неплохо подходят друг другу.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 72%.";
            BasicCompatibility_Text.text = "Она довольно яркая и активная, он же не привык особенно напрягаться. Интересно, сумеет ли она хотя бы немного растормошить его?";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Это представители противоположных знаков зодиака, именно поэтому им так непривычно хорошо вместе.";
            }

            //рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 71%.";
            BasicCompatibility_Text.text = "Она — неутомимая оптимистка, он — скромный обольститель. Интересно, как будут складываться их отношения?";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Они оба — чистый огонь. Помогут ли они друг другу разгореться еще сильней?";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Они очень разные. Она — яркая и целеустремленная, настоящий энтузиаст. Он — спокойный и деловитый. Что связывает их?";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Они довольно неплохо подходят другу. Им будет приятно и нескучно вместе.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Они оба страстные, уверенные в себе. Возможно, она немного робеет перед ним, но только поначалу.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Если вы когда-нибудь видели людей, которые отражают друг друга, словно в зеркале, вероятно, это были женщина и мужчина-Стрелец.";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 79%.";
            BasicCompatibility_Text.text = "Она нуждается в непрерывном развитии и частой смене впечатлений, он – в стабильности и постоянстве. Что они делают вместе?";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Они оба порывистые, свободные и энергичные. Их пара похожа на союз солнца и ветра — звучит очень привлекательно, правда?";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 71%.";
            BasicCompatibility_Text.text = "Часто они думают одинаково. Общее мировоззрение значит для них больше, чем страсть и влечение.";
            }
        }

        // КОЗЕРОГ
        if (Your_Zodiac == 9)
        {
            //овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Они подходят друг другу. Правда, иногда она будет уставать от его напора.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 86%.";
            BasicCompatibility_Text.text = "Она — само совершенство. Он — образец спокойствия и стабильности. Нужен ли им кто-то еще?";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 71%.";
            BasicCompatibility_Text.text = "Она серьезная, строгая, правильная. Он – разгильдяй. Герой, от которого все без ума. Все, кроме неприступной женщины-Козерога.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Они — прямые противоположности друг друга. Интересно, что их все-таки связывает?";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Возможно, ее будут раздражать его царские замашки."; 
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 85%.";
            BasicCompatibility_Text.text = "Она — целеустремленная и прагматичная, он — «весь в себе»: практичный, работящий, эмоционально-закрытый. Они так похожи — не будет ли им скучно?";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 81%.";
            BasicCompatibility_Text.text = "Мужчина-Весы, безусловно, сумеет найти подход к женщине-Козерогу. Она, в свою очередь, одарит его своим вниманием, которое, к слову, перепадает немногим.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Женщина-Козерог – воплощение холодной страсти. Она само совершенство, но некому растопить ее лед. Постойте, а как же мужчина-Скорпион?";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Они оба любят достигать своих целей, но они у них такие разные. Женщина-Козерог и мужчина-Стрелец, несомненно, привлекут друг друга, но надолго ли?";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 84%.";
            BasicCompatibility_Text.text = "Они стоят друг друга. Оба практичные, целеустремленные и… зацикленные на себе.";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Это очень интересная пара. Она пытается его ограничить, а он никак не ограничивается.";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 67%.";
            BasicCompatibility_Text.text = "Она любит разговаривать начистоту, он привык уходить от прямых вопросов. Найдут ли они общий язык?";
            }
        }

        // ВОДОЛЕЙ
        if (Your_Zodiac == 10)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Она – независимая и свободолюбивая, он – яркий собственник. Пожалуй, она для него – как раз то, что нужно.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Это союз стабильности и оригинальности, надежности и бесшабашности.";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Они оба любят легкость и свободу в отношениях. Кажется, это идеальная пара.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 66%.";
            BasicCompatibility_Text.text = "Она стремится к свободе, он — к безопасности. Кажется, их графики не пересекаются. Хотя, постойте…";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Они притягиваются, как и положено противоположностям. И, соответственно, отталкиваются.";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 67%.";
            BasicCompatibility_Text.text = "Они довольно разные. Она любит свободу, а он – порядок.";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Они оба принадлежат к стихии воздуха, она – немного более оригинальная и свободолюбивая, он же приверженец долгих и глубоких отношений.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 89%.";
            BasicCompatibility_Text.text = "Она нежная, он страстный. Возможно, это оно из лучших сочетаний.";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Они очень похожи: оба свободолюбивые и жизнерадостные. Возможно, они нашли друг друга.";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 92%.";
            BasicCompatibility_Text.text = "Она-оригинальна и свободолюбивая, он – суров, серьезен, но все-таки довольно мил. Интересно, сможет ли он удержать ее?";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 77%.";
            BasicCompatibility_Text.text = "Женщина-Водолей — это ураган, мужчина-Водолей — тоже. Когда они вместе, это двойной ураган — штука захватывающая и опасная.";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "У них похожие взгляды. Кажется, они сумеют понять друг друга достаточно глубоко.";
            }
        }

        // РЫБЫ
        if (Your_Zodiac == 11)
        {
            // овен
            if (Friend_Zodiac == 0){
            PercentCompatibility_Text.text = "Совместимы на 85%.";
            BasicCompatibility_Text.text = "Она — мечтательная и романтичная, он — смелый и напористый. Отличное сочетание.";
            }

            // телец
            if (Friend_Zodiac == 1){
            PercentCompatibility_Text.text = "Совместимы на 82%.";
            BasicCompatibility_Text.text = "Они неплохо понимают друг друга, правда, иногда он ей может показаться немного грубым и бесчувственным. А она ему — скучной и неинтересной.";
            }

            // близнецы
            if (Friend_Zodiac == 2){
            PercentCompatibility_Text.text = "Совместимы на 81%.";
            BasicCompatibility_Text.text = "Они и похожи, и очень отличаются. Попробуем разобраться, чем именно.";
            }

            // рак
            if (Friend_Zodiac == 3){
            PercentCompatibility_Text.text = "Совместимы на 83%.";
            BasicCompatibility_Text.text = "Они очень похожи. Непонятно только, это плюс в их случае или минус.";
            }

            // лев
            if (Friend_Zodiac == 4){
            PercentCompatibility_Text.text = "Совместимы на 95%.";
            BasicCompatibility_Text.text = "Она – нежная и неуловимая, он – харизматичный, знает о себе многое, в основном то, что он лучший. Сумеет ли он «поймать» ее?";
            }

            // дева
            if (Friend_Zodiac == 5){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Она погружена в себя, он практичен и реалистичен. Есть ли у них что-то общее?";
            }

            // весы
            if (Friend_Zodiac == 6){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Они оба нерешительные и стремящиеся к гармонии.";
            }

            // скорпион
            if (Friend_Zodiac == 7){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Они оба достаточно чувственны и эмоцинальны, чтобы прекрасно понимать друг друга. Где та грань, за которой их отличия начнут проявляться настолько ярко, чтобы они наконец заметили их?..";
            }

            // стрелец
            if (Friend_Zodiac == 8){
            PercentCompatibility_Text.text = "Совместимы на 74%.";
            BasicCompatibility_Text.text = "Женщина-Рыбы, пожалуй, самая неуловимая из всех. Мужчина-Стрелец тоже неуловим, но по-своему. Кто кого будет догонять?";
            }

            // козерог
            if (Friend_Zodiac == 9){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Женщина-Рыбы и мужчина-Козерог — тот редкий случай, когда все сходится. Ну, или почти все.";
            }

            // водолей
            if (Friend_Zodiac == 10){
            PercentCompatibility_Text.text = "Совместимы на 93%.";
            BasicCompatibility_Text.text = "Они похожи: он не признает границ, а для нее любые границы уже давно стерты.";
            }

            // рыбы
            if (Friend_Zodiac == 11){
            PercentCompatibility_Text.text = "Совместимы на 100%.";
            BasicCompatibility_Text.text = "Это союз двух неуловимых и загадочных личностей, одна из которых к тому же и женщина.";
            }
        }
    }

    // Обновить данные изображений
    private void ImgUpdate ()
    {
        // овен
        if (Friend_Zodiac == 0){
        FriendZodiac_Img_Scene.sprite = Oven;
        FriendZodiac_Img_Rezult.sprite = Oven;
        Friend_Zodiac_text.text = "Овен";
        }
        if (Your_Zodiac == 0){
        YourZodiac_Img_Scene.sprite = Oven;
        YourZodiac_Img_Rezult.sprite = Oven;
        Your_Zodiac_Text.text = "Овен";
        }

        // телец
        if (Friend_Zodiac == 1){
        FriendZodiac_Img_Scene.sprite = Telec;
        FriendZodiac_Img_Rezult.sprite = Telec;
        Friend_Zodiac_text.text = "Телец";
        }
        if (Your_Zodiac == 1){
        YourZodiac_Img_Scene.sprite = Telec;
        YourZodiac_Img_Rezult.sprite = Telec;
        Your_Zodiac_Text.text = "Телец";
        }

        // близнецы
        if (Friend_Zodiac == 2){
        FriendZodiac_Img_Scene.sprite = Blizneci;
        FriendZodiac_Img_Rezult.sprite = Blizneci;
        Friend_Zodiac_text.text = "Близнецы";
        }
        if (Your_Zodiac == 2){
        YourZodiac_Img_Scene.sprite = Blizneci;
        YourZodiac_Img_Rezult.sprite = Blizneci;
        Your_Zodiac_Text.text = "Близнецы";
        }

        // рак
        if (Friend_Zodiac == 3){
        FriendZodiac_Img_Scene.sprite = Rak;
        FriendZodiac_Img_Rezult.sprite = Rak;
        Friend_Zodiac_text.text = "Рак";
        }
        if (Your_Zodiac == 3){
        YourZodiac_Img_Scene.sprite = Rak;
        YourZodiac_Img_Rezult.sprite = Rak;
        Your_Zodiac_Text.text = "Рак";
        }

        // лев
        if (Friend_Zodiac == 4){
        FriendZodiac_Img_Scene.sprite = Lev;
        FriendZodiac_Img_Rezult.sprite = Lev;
        Friend_Zodiac_text.text = "Лев";
        }
        if (Your_Zodiac == 4){
        YourZodiac_Img_Scene.sprite = Lev;
        YourZodiac_Img_Rezult.sprite = Lev;
        Your_Zodiac_Text.text = "Лев";
        }

        // дева
        if (Friend_Zodiac == 5){
        FriendZodiac_Img_Scene.sprite = Deva;
        FriendZodiac_Img_Rezult.sprite = Deva;
        Friend_Zodiac_text.text = "Дева";
        }
        if (Your_Zodiac == 5){
        YourZodiac_Img_Scene.sprite = Deva;
        YourZodiac_Img_Rezult.sprite = Deva;
        Your_Zodiac_Text.text = "Дева";
        }

        // весы
        if (Friend_Zodiac == 6){
        FriendZodiac_Img_Scene.sprite = Vesy;
        FriendZodiac_Img_Rezult.sprite = Vesy;
        Friend_Zodiac_text.text = "Весы";
        }
        if (Your_Zodiac == 6){
        YourZodiac_Img_Scene.sprite = Vesy;
        YourZodiac_Img_Rezult.sprite = Vesy;
        Your_Zodiac_Text.text = "Весы";
        }

        // скорпион
        if (Friend_Zodiac == 7){
        FriendZodiac_Img_Scene.sprite = Skorpion;
        FriendZodiac_Img_Rezult.sprite = Skorpion;
        Friend_Zodiac_text.text = "Скорпион";
        }
        if (Your_Zodiac == 7){
        YourZodiac_Img_Scene.sprite = Skorpion;
        YourZodiac_Img_Rezult.sprite = Skorpion;
        Your_Zodiac_Text.text = "Скорпион";
        }

        // стрелец
        if (Friend_Zodiac == 8){
        FriendZodiac_Img_Scene.sprite = Strelec;
        FriendZodiac_Img_Rezult.sprite = Strelec;
        Friend_Zodiac_text.text = "Стрелец";
        }
        if (Your_Zodiac == 8){
        YourZodiac_Img_Scene.sprite = Strelec;
        YourZodiac_Img_Rezult.sprite = Strelec;
        Your_Zodiac_Text.text = "Стрелец";
        }

        // козерог
        if (Friend_Zodiac == 9){
        FriendZodiac_Img_Scene.sprite = Kozeroh;
        FriendZodiac_Img_Rezult.sprite = Kozeroh;
        Friend_Zodiac_text.text = "Козерог";
        }
        if (Your_Zodiac == 9){
        YourZodiac_Img_Scene.sprite = Kozeroh;
        YourZodiac_Img_Rezult.sprite = Kozeroh;
        Your_Zodiac_Text.text = "Козерог";
        }

        // водолей
        if (Friend_Zodiac == 10){
        FriendZodiac_Img_Scene.sprite = Vodoley;
        FriendZodiac_Img_Rezult.sprite = Vodoley;
        Friend_Zodiac_text.text = "Водолей";
        }
        if (Your_Zodiac == 10){
        YourZodiac_Img_Scene.sprite = Vodoley;
        YourZodiac_Img_Rezult.sprite = Vodoley;
        Your_Zodiac_Text.text = "Водолей";
        }

        // рыбы
        if (Friend_Zodiac == 11){
        FriendZodiac_Img_Scene.sprite = Ryby;
        FriendZodiac_Img_Rezult.sprite = Ryby;
        Friend_Zodiac_text.text = "Рыбы";
        }
        if (Your_Zodiac == 11){
        YourZodiac_Img_Scene.sprite = Ryby;
        YourZodiac_Img_Rezult.sprite = Ryby;
        Your_Zodiac_Text.text = "Рыбы";
        }
    }
}
