using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page {
    List<String> wordList = new List<String>();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e) {
        if (Session["myWordList"] == null) {
            Session["myWordList"] = wordList;
        }
        else
           secondSection.Visible = true;
        wordList = (List<String>)Session["myWordList"];
        dt.Columns.Add(new DataColumn());
        dt.Columns.Add(new DataColumn());
        dt.Columns.Add(new DataColumn());
        dt.Columns.Add(new DataColumn());
        populateTable();
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        wordList.Add(TextBox1.Text.ToString());
        wordList.Sort();
        Session["myWordList"] = wordList;
        populateTable();
    }

    protected void Button2_Click(object sender, EventArgs e) {
        wordList.Remove(TextBox2.Text.ToString());
        wordList.Sort();
        Session["myWordList"] = wordList;
        populateTable();
    }

    protected void populateTable() {
        int wordCount = wordList.Count;
        int byFour = wordCount / 4;
        int byFourRemain = wordCount % 4;
        int rowCount = 0;
        int wordsRemaining = wordCount;
        int wordsLastRow;

        dt.Clear();

        for (int i = 0; i < wordCount - 3; i += 4) {
            int j = i + 1;
            int k = i + 2;
            int l = i + 3;
            dt.Rows.Add(wordList[i], wordList[j], wordList[k], wordList[l]);
            wordsRemaining -= 4;
            rowCount++;
        }
        wordsLastRow = rowCount * 4;
        wordsLastRow += wordsRemaining;

        if (byFourRemain > 0 == true) {
            if (byFourRemain > 1 == true) {
                if (byFourRemain > 2 == true) {
                    int i = wordsLastRow - 3;
                    int j = wordsLastRow - 2;
                    int k = wordsLastRow - 1;
                    dt.Rows.Add(wordList[i], wordList[j], wordList[k], null);
                }
                else {
                    int i = wordsLastRow - 2;
                    int j = wordsLastRow - 1;
                    dt.Rows.Add(wordList[i], wordList[j], null, null);
                }
            }
            else {
                int i = wordsLastRow - 1;
                dt.Rows.Add(wordList[i], null, null, null);
            }
        }

        GridView1.DataSource = dt;
        GridView1.DataBind();
        secondSection.Visible = true;
        if (dt.Rows.Count == 0) {
            secondSection.Visible = false;
        }
    }
}