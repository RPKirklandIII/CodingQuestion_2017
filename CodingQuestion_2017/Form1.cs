using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CodingQuestion_2017
{
  public partial class Form1 : Form
  {
    #region Properties
    private int pixelCount;
    private int rows;
    private int columns;
    private int x1;
    private int x2;
    private int y1;
    private int y2;
    private Graphics surface;
    private readonly List<string> x1y1List = new List<string>();
    private readonly List<string> x2y2List = new List<string>();
    private readonly List<string> x3y3List = new List<string>();
    private bool x1y1Selected = false;
    private bool x2y2Selected = false;
    private bool x3y3Selected = false;
    private int xSelectedValue;
    private int ySelectedValue;
    #endregion Properties

    #region Init
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Initialize the drop downs to a value of 6
      cboRows.SelectedIndex = 5;
      cboColumns.SelectedIndex = 5;
    }
    #endregion Init

    #region Draw Triangles

    #region Methods
    private void CalculateTriangles()
    {
      // Now start calculating and drawing all the triangles.
      for (int column = 1; column <= columns; column++)
      {
        // Need to determine X-axis based on which column we are on.
        x1 = column == 1 ? 0 : (column - 1) * pixelCount;
        x2 = column * pixelCount;

        // Need to determine the Y-axis based on which row we are on.
        for (int row = 1; row <= rows; row++)
        {
          y1 = row == 1 ? 0 : (row - 1) * pixelCount;
          y2 = row * pixelCount;

          // We should have all the trianlge points now. Let's draw it and enter hte coordinates into the dictionary.
          // Blue triangle
          DrawTriangle(new Point(x1, y1), new Point(x2, y2), new Point(x1, y2), new SolidBrush(Color.Blue));
          LogTriangleCoordinates("Blue", row, column);

          // Red Triangle
          DrawTriangle(new Point(x1, y1), new Point(x2, y1), new Point(x2, y2), new SolidBrush(Color.Red));
          LogTriangleCoordinates("Red", row, column);
        }
      }
    }

    private void LogTriangleCoordinates(string name, int row, int column)
    {
      // Let's make a list of each of coordinates for each triangle.
      if (name == "Blue")
      {
        x1y1List.Add(x1 + "," + y2);
      }
      else
      {
        x1y1List.Add(x2 + "," + y1);
      }

      x2y2List.Add(x1 + "," + y1);
      x3y3List.Add(x2 + "," + y2);
    }

    private void DrawTriangle(Point pointA, Point pointB, Point pointC, SolidBrush brush)
    {
      surface = this.CreateGraphics();

      Point[] points = { pointA, pointB, pointC };
      surface.FillPolygon(brush, points);
    }

    private void ClearTriangleCoordinates()
    {
      // We need to clear all the coordinates loaded into the drop downs so they can reloaded based on what the user selects.
      cboX1Y1Values.Items.Clear();
      cboX2Y2Values.Items.Clear();
      cboX3Y3Values.Items.Clear();
      // Reset the selected boolean values.
      x1y1Selected = false;
      x2y2Selected = false;
      x3y3Selected = false;
    }

    private void ClearTriangleLists()
    {
      // We need to clear the lists that are being used to load into the drop downs.
      x1y1List.Clear();
      x2y2List.Clear();
      x3y3List.Clear();
    }

    private void LoadCoordinates()
    {
      // This is where we will clean up, sort and load the coordinate values into the drop downs.

      // First remove any duplicates
      List<string> x1y1ListDistinct = x1y1List.Distinct().ToList();
      List<string> x2y2ListDistinct = x2y2List.Distinct().ToList();
      List<string> x3y3ListDistinct = x3y3List.Distinct().ToList();

      // Second sort them
      x1y1ListDistinct.Sort();
      x2y2ListDistinct.Sort();
      x3y3ListDistinct.Sort();

      // Finally load then into the drop downs
      foreach (string s in x1y1ListDistinct)
      {
        cboX1Y1Values.Items.Add(s);
      }
      foreach (string s in x2y2ListDistinct)
      {
        cboX2Y2Values.Items.Add(s);
      }
      foreach (string s in x3y3ListDistinct)
      {
        cboX3Y3Values.Items.Add(s);
      }
    }

    private void ClearTheForm()
    {
      // Clear the form to remove the images already drawn.
      if (surface == null)
      {
        surface = this.CreateGraphics();
      }

      surface.Clear(Color.White);
    }
    #endregion Methods

    #region EventHandlers

    private void btnDrawTiangles_Click(object sender, EventArgs e)
    {
      // First need to determine the number of pixels the user entered and alert them if they didn't enter a numeric value.
      bool result = int.TryParse(txtPixelCount.Text, out pixelCount);

      if (result)
      {
        if (pixelCount > 90)
        {
          // The user entered a value that will cause the images to exceed the boundries of the form. 
          // Alert them and let them decide to continue or not.
          DialogResult largePixelCountResult =
            MessageBox.Show(
              "You select a pixel count that will cause the image to leave the boundries of the form. Do you wish to continue",
              "Pixel Count", MessageBoxButtons.YesNo);

          // Check the user's response to see if they want ot continue.
          if (largePixelCountResult != DialogResult.Yes)
          {
            // The user wants to stop.
            return;
          }
        }
        // Next need to determien the number of rows and columns.
        rows = Convert.ToInt16(cboRows.SelectedItem);
        columns = Convert.ToInt16(cboColumns.SelectedItem);

        // Clear the form in case there are triangles already drawn.
        ClearTheForm();
        // We need to clear the list objects to start over.
        ClearTriangleLists();
        // Now that we have the user inputs calculate and draw the images.
        CalculateTriangles();
        // Load all the coordinate values into the dropdowns. Clear first to make sure they are empty.
        ClearTriangleCoordinates();
        LoadCoordinates();
        // Now enable all the find controls to allow the user to find a triangle
        ActivateFindControls();
        // Clear the possible image location lable.
        lblImageLocation.Text = "";
      }
      else
      {
        // The value entered into the pixel count textbox was not numeric. Alert the user.
        MessageBox.Show("The pixel value was not numeric. Please check and re-try.", "Pixel Value Error",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnClearTriangles_Click(object sender, EventArgs e)
    {
      // Clear the form to remove the images already drawn.
      ClearTheForm();

      // Now disable all the find controls to require the user to re-draw the trianlges again.
      DeactivateFindControls();

      // Now clear all the of drop downs so they can be reloaded the next time the triangles are drawn.
      ClearTriangleCoordinates();

      // We need to clear the list objects to start over.
      ClearTriangleLists();

      // Clear the possible image location lable.
      lblImageLocation.Text = "";
    }
    #endregion EventHandlers

    #endregion Draw Triangles

    #region Find Triangle

    #region Methods

    private void ActivateFindControls()
    {
      cboX1Y1Values.Enabled = true;
      cboX2Y2Values.Enabled = true;
      cboX3Y3Values.Enabled = true;
      btnLocateImage.Enabled = true;
    }

    private void DeactivateFindControls()
    {
      cboX1Y1Values.Enabled = false;
      cboX2Y2Values.Enabled = false;
      cboX3Y3Values.Enabled = false;
      btnLocateImage.Enabled = false;
    }

    private void BreakSelectedCoordinateApart(string selecetdCoordinate)
    {
      xSelectedValue = Convert.ToInt32(selecetdCoordinate.Substring(0, selecetdCoordinate.IndexOf(',')));
      ySelectedValue = Convert.ToInt32(selecetdCoordinate.Substring(selecetdCoordinate.IndexOf(',') + 1));
    }

    private string Number2String(int number, bool isCaps)
    {
      Char c = (Char)((isCaps ? 65 : 97) + (number));
      return c.ToString();
    }
    
    #endregion Methods

    #region EventHandlers
    private void btnLocateImage_Click(object sender, EventArgs e)
    {
      // First we need to make sure that the user selected a value from all 3 dropdowns.
      // If not alert them since we will need all 3 to locate the triangle image.
      if (cboX1Y1Values.SelectedItem != null && cboX2Y2Values.SelectedItem != null &&
          cboX3Y3Values.SelectedItem != null)
      {
        // Grab the selected values and break them into seperate values.
        string x1y1SelectedCoordinates = cboX1Y1Values.SelectedItem.ToString();
        int x1Selected = Convert.ToInt32(x1y1SelectedCoordinates.Substring(0, x1y1SelectedCoordinates.IndexOf(',')));
        int y1Selected = Convert.ToInt32(x1y1SelectedCoordinates.Substring(x1y1SelectedCoordinates.IndexOf(',') + 1));
        string x2y2SelectedCoordinates = cboX2Y2Values.SelectedItem.ToString();
        int x2Selected = Convert.ToInt32(x2y2SelectedCoordinates.Substring(0, x2y2SelectedCoordinates.IndexOf(',')));
        int y2Selected = Convert.ToInt32(x2y2SelectedCoordinates.Substring(x2y2SelectedCoordinates.IndexOf(',') + 1));
        string x3y3SelectedCoordinates = cboX3Y3Values.SelectedItem.ToString();
        int x3Selected = Convert.ToInt32(x3y3SelectedCoordinates.Substring(0, x3y3SelectedCoordinates.IndexOf(',')));
        int y3Selected = Convert.ToInt32(x3y3SelectedCoordinates.Substring(x3y3SelectedCoordinates.IndexOf(',') + 1));

        int column = 0;
        int row = 0;
        if (x1Selected > x2Selected)
        {
          // This is an even triangle image based on the x1 & x2 coordinates.
          column = (x1Selected / pixelCount) * 2;
          if (y1Selected > 0)
          {
            row = (y1Selected / pixelCount);
          }
          else
          {
            row = 0;
          }
        }

        if (x1Selected == x2Selected)
        {
          // This is an odd triangle image based on the x1 & x2 coordinates.
          column = ((x1Selected / pixelCount) * 2) + 1;
          if (y1Selected > 0)
          {
            row = (y1Selected/pixelCount) - 1;
          }
          else
          {
            column = 1;
            row = 0;
          }
        }

        string rowLetter = Number2String(row, true);
        lblImageLocation.Text = "The coordinates are the image located at " + rowLetter + column;

        DrawTriangle(new Point(x1Selected, y1Selected), new Point(x2Selected, y2Selected), new Point(x3Selected, y3Selected), new SolidBrush(Color.White));

        DeactivateFindControls();
      }
      else
      {
        // Not all drop downs have a selected value. Alert the user.
        MessageBox.Show("Not all coordinate drop downs have a selected value. Please check and re-try",
          "Select Coordinates", MessageBoxButtons.OK);
      }
    }

    private void cboX1Y1Values_SelectedIndexChanged(object sender, EventArgs e)
    {
      // Grab the selected values and break them into seperate values.
      BreakSelectedCoordinateApart(cboX1Y1Values.SelectedItem.ToString());

      bool borderCoordinate = false;
      // First perform checks to make sure the other dropdowns were not selected first.
      if (!x2y2Selected)
      {
        // The x2y2 coordinate drop down has not been selected yet.
        // First we need to make sure the selected coordinate isn't on the border?
        if (xSelectedValue == 0 || ySelectedValue == (columns * pixelCount))
        {
          // This point is along the left boundry so it can only be an odd image.
          // We can determine the only options from this one point.
          cboX2Y2Values.Items.Clear();
          cboX2Y2Values.Items.Add(xSelectedValue + "," + (ySelectedValue - pixelCount));
          borderCoordinate = true;
        }
        if (ySelectedValue == 0 || xSelectedValue == (rows * pixelCount))
        {
          // This point is along the top boundry so it can only be a even image.
          // We can determine the only options from this one point.
          cboX2Y2Values.Items.Clear();
          cboX2Y2Values.Items.Add((xSelectedValue - pixelCount) + "," + ySelectedValue);
          borderCoordinate = true;
        }
        if (!borderCoordinate)
        {
          // If we made it here then the selected coordinate is not located on the boundry on the images.
          cboX2Y2Values.Items.Clear();
          cboX2Y2Values.Items.Add((xSelectedValue - pixelCount) + "," + ySelectedValue);
          cboX2Y2Values.Items.Add(xSelectedValue + "," + (ySelectedValue - pixelCount));
        }
      }

      if (!x3y3Selected)
      {
        // The x3y3 coordinate drop down has not been selected yet.
        // First we need to make sure the selected coordinate isn't on the border?
        if (xSelectedValue == 0 || ySelectedValue == (columns * pixelCount))
        {
          // This point is along the left/bottom boundry so it can only be an odd image.
          // We can determine the only options from this one point.
          cboX3Y3Values.Items.Clear();
          cboX3Y3Values.Items.Add((xSelectedValue + pixelCount) + "," + ySelectedValue);
          borderCoordinate = true;
        }
        if (ySelectedValue == 0 || xSelectedValue == (rows * pixelCount))
        {
          // This point is along the top/right boundry so it can only be a even image.
          // We can determine the only options from this one point.
          cboX3Y3Values.Items.Clear();
          cboX3Y3Values.Items.Add(xSelectedValue + "," + (ySelectedValue + pixelCount));
          borderCoordinate = true;
        }
        if (!borderCoordinate)
        {
          // If we made it here then the selected coordinate is not located on the boundry on the images.
          cboX3Y3Values.Items.Clear();
          cboX3Y3Values.Items.Add(xSelectedValue + "," + (ySelectedValue + pixelCount));
          cboX3Y3Values.Items.Add((xSelectedValue + pixelCount) + "," + ySelectedValue);
        }
      }
      x1y1Selected = true;
    }

    private void cboX2Y2Values_SelectedIndexChanged(object sender, EventArgs e)
    {
      // Grab the selected values and break them into seperate values.
      BreakSelectedCoordinateApart(cboX2Y2Values.SelectedItem.ToString());

      // First perform checks to make sure the other dropdiwns were not selected first.
      if (!x1y1Selected)
      {
        // The x1y1 coordinate drop down has not been selected yet.
        // We can determine the only options from this one point.
        cboX1Y1Values.Items.Clear();
        cboX1Y1Values.Items.Add(xSelectedValue + "," + (ySelectedValue + pixelCount));
        cboX1Y1Values.Items.Add((xSelectedValue + pixelCount) + "," + ySelectedValue);
      }

      if (!x3y3Selected)
      {
        // The x3y3 coordinate drop down has not been selected yet.
        // We can determine the only options from this one point.
        cboX3Y3Values.Items.Clear();
        cboX3Y3Values.Items.Add((xSelectedValue + pixelCount) + "," + (ySelectedValue + pixelCount));
      }
      x2y2Selected = true;
    }

    private void cboX3Y3Values_SelectedIndexChanged(object sender, EventArgs e)
    {
      // Grab the selected values and break them into seperate values.
      BreakSelectedCoordinateApart(cboX3Y3Values.SelectedItem.ToString());

      // First perform checks to make sure the other dropdiwns were not selected first.
      if (!x1y1Selected)
      {
        // The x1y1 coordinate drop down has not been selected yet.
        // We can determine the only options from this one point.
        cboX1Y1Values.Items.Clear();
        cboX1Y1Values.Items.Add(xSelectedValue + "," + (ySelectedValue - pixelCount));
        cboX1Y1Values.Items.Add((xSelectedValue - pixelCount) + "," + ySelectedValue);
      }

      if (!x2y2Selected)
      {
        // The x2y2 coordinate drop down has not been selected yet.
        // We can determine the only options from this one point.
        cboX2Y2Values.Items.Clear();
        cboX2Y2Values.Items.Add((xSelectedValue - pixelCount) + "," + (ySelectedValue - pixelCount));
      }
      x3y3Selected = true;
    }

    #endregion EventHandlers

    #endregion Find Triangle
  }
}
