using OpenQA.Selenium;


namespace testAutoation_c_sharpe_nUnit.Page;

public class CheckAnswers : BasePage
{


    private readonly By riddle_stone_id_l1 = By.Id("r1Input");

    private readonly By riddle_answer_btn_id_l2 = By.Id("r1Btn");

    private readonly By secret_key_css_l3 = By.CssSelector("div[id='passwordBanner'] h4");

    private readonly By enter_secret_key_id_l4 = By.Id("r2Input");

    private readonly By button_for_secret_key_l5 = By.Id("r2Butn");

    private readonly By first_success_message_css_l6 = By.Id("div[id='successBanner1'] h4");

    public CheckAnswers(IWebDriver driver) : base(driver)
    {
    }



    public void setRiddleOfStone()
    {
        Click(riddle_stone_id_l1);
        SendKeys(riddle_stone_id_l1, "rock");
    }

    public void click_riddleOfStone()
    {
        Click(riddle_answer_btn_id_l2);
    }

    public string copySecretKey()
    {
        return ReturnText(secret_key_css_l3);
    }

    public void click_secretkey_input_box()
    {
        Click(enter_secret_key_id_l4);
    }

    public void set_secret_key(string password)
    {
        SendKeys(enter_secret_key_id_l4, password);
    }

    public void click_secretKey_button()
    {
        Click(button_for_secret_key_l5);
    }

    public string read_success_message()
    {
        return ReturnText(first_success_message_css_l6);
    }

    private readonly By merchant1_xp_l1 = By.XPath("(//b[normalize-space()='Jessica'])[1]");

    private readonly By merchant1_wealth_xp_l2 = By.XPath("(//p[normalize-space()='3000'])[1]");

    private readonly By merchant2_xp_l3 = By.XPath("(//b[normalize-space()='Bernard'])[1]");

    private readonly By merchant2_wealth_xp_l4 = By.XPath("(//p[normalize-space()='2000'])[1]");

    private readonly By richest_input_box_id_l5 = By.Id("r3Input");

    private readonly By button_for_richest_id_l6 = By.Id("r3Butn");

    private readonly By second_success_message_css_l7 = By.CssSelector("div[id='successBanner2'] h4");

    public string copy_merchant_1()
    {
        return ReturnText(merchant1_xp_l1);
    }

    public int copy_mer1_wealth()
    {
        string m1_wealth = ReturnText(merchant1_wealth_xp_l2);
        int m1_wealth_int = Convert.ToInt32(m1_wealth);
        return m1_wealth_int;
    }

    public string copy_merchant_2()
    {
        return ReturnText(merchant2_xp_l3);
    }

    public int copy_mer2_wealth()
    {
        string m2_wealth = ReturnText(merchant2_wealth_xp_l4);
        int m2_wealth_int = Convert.ToInt32(m2_wealth);
        return m2_wealth_int;
    }

    public void submit_richest_name(string rich_name)
    {
        Click(richest_input_box_id_l5);
        SendKeys(richest_input_box_id_l5, rich_name);
    }

    public void click_answer_button_2()
    {
        Click(button_for_richest_id_l6);
    }

    public string assert_two_merchant()
    {
        return ReturnText(second_success_message_css_l7);
    }

    private readonly By check_answers_btn_id = By.Id("checkButn");

    private readonly By assert_Trail_complete_xp = By.Id("(//h4[normalize-space()='Trial Complete'])[1]");

    public void click_check_answers()
    {
        Click(check_answers_btn_id);
    }

    public string trail_complete_message()
    {
        return ReturnText(assert_Trail_complete_xp);
    }
}
