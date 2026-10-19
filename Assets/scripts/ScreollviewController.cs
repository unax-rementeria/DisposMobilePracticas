using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class ScreollviewController : MonoBehaviour
{

    void Start()
    {
        //crollView scrollView = this.gameObject.GetComponent<ScrollView>();
        var scrollView = new ScrollView(ScrollViewMode.VerticalAndHorizontal);

        // Add a label and 100 toggle elements to the ScrollView.
        scrollView.Add(new Label("List of checkboxes:"));
        scrollView = GetComponent<ScrollView>();

        for (int i = 0; i < 20; ++i)
        {
            var toggle = new UnityEngine.UIElements.Toggle()
            { text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." };
            scrollView.Add(toggle);
        }

        // Access the vertical scroller.
        var verticalScroller = scrollView.verticalScroller;
    }
}
