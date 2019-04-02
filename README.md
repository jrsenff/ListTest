# ListTest

Fun little Windows Form application using List<> with a class call Test which has data members for a student's name and a test number.

- A student submits a test which gets added to the Submitted Tests list box. 
- If the student wants to review the test, the submitted test is moved to the Checked Out Tests list box.
- When the student returns the test, it is moved from the Checked Out Tests list box back to the Submitted Tests list box.
- The Exit button moves all tests from the Checked Out Tests list box to the Submitted Tests list box and closes the application.

Features:
- Alt-keys button activation
- Mouse hover tooltips
- Mouse double-click support for moving tests between list boxes with confirmation message box
- Tab order flows from Student Name to Test Number and then top to bottom through the four buttons
- Default text box focus gets set depending on what error message returned for missing text box data
- Default button focus on Submit Test button
- Accept button set to Submit Test button for Return press
