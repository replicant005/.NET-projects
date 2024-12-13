/* Author - mehak kapur 
 * Date - 7/12/2024
 * Description : Class for questions
 */

namespace PersonalityTestFinal
{
    public class Questions
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public string SelectedOption { get; set; }
    }
}
