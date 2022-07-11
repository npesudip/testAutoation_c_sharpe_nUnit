using testAutoation_c_sharpe_nUnit.Page;


namespace testAutoation_c_sharpe_nUnit.Test
{
    [TestFixture]


    public class Test_NinjaTrails : BaseTest
    {

        public void Test_001_riddleOfStone()
        {
            CheckAnswers checkAnswers = new(base.Driver);
            checkAnswers.click_riddleOfStone();
            string secret_key = checkAnswers.copySecretKey();
            checkAnswers.click_secretkey_input_box();
            checkAnswers.set_secret_key(secret_key);
            checkAnswers.click_secretKey_button();
            string success_message = checkAnswers.read_success_message();
            Assert.That(success_message, Is.EqualTo("Success!"));

        }

        public void Test_002_merchant_wealth()
        {
            CheckAnswers checkAnswers = new(base.Driver);
            string m1 = checkAnswers.copy_merchant_1();
            int m1_wealth = checkAnswers.copy_mer1_wealth();
            string m2 = checkAnswers.copy_merchant_2();
            int m2_wealth = checkAnswers.copy_mer2_wealth();
            if (m1_wealth > m2_wealth)
            {
                checkAnswers.submit_richest_name(rich_name: m1);
            }
            else
            {
                checkAnswers.submit_richest_name(rich_name: m2);
            }
            checkAnswers.click_answer_button_2();

            var success_message2 = checkAnswers.assert_two_merchant();
            Assert.That(success_message2, Is.EqualTo("Success!"));

        }

        public void Test_003_check_answers()    {


            CheckAnswers checkAnswers = new(base.Driver);
            checkAnswers.click_riddleOfStone();
            string secret_key = checkAnswers.copySecretKey();
            checkAnswers.click_secretkey_input_box();
            checkAnswers.set_secret_key(secret_key);
            checkAnswers.click_secretKey_button();
            string success_message = checkAnswers.read_success_message();

            string m1 = checkAnswers.copy_merchant_1();
            int m1_wealth = checkAnswers.copy_mer1_wealth();
            string m2 = checkAnswers.copy_merchant_2();
            int m2_wealth = checkAnswers.copy_mer2_wealth();
            if (m1_wealth > m2_wealth)
            {
                checkAnswers.submit_richest_name(rich_name: m1);
            }
            else
            {
                checkAnswers.submit_richest_name(rich_name: m2);
            }
            checkAnswers.click_answer_button_2();

            var success_message2 = checkAnswers.assert_two_merchant();

            checkAnswers.click_check_answers();

            string success_message3 = checkAnswers.trail_complete_message();

            Assert.That(success_message3, Is.EqualTo("Success!"));

        }
    }
}

