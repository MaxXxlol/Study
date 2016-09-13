
#include <QApplication>
#include <QWidget>
#include <QPushButton>
#include <QLabel>
#include <QSpinBox>
#include <QRadioButton>
#include <QTextEdit>
#include <QFormLayout>
#include <QGridLayout>
#include <QBoxLayout>

int main (int argc, char **argv)
{
    QApplication app(argc, argv);
    QWidget widget(0);

    QGridLayout grid_layout;
    widget.setLayout(&grid_layout);

    QFormLayout form_layout;
    QVBoxLayout v_box_layout;
    QHBoxLayout hor_box_layout;

    grid_layout.addLayout(&form_layout, 0, 0);
    grid_layout.addLayout(&v_box_layout, 0, 1);
    grid_layout.addLayout(&hor_box_layout, 2, 0, 1, 2);

    // Populating the upper left box with checkboxes
    QSpinBox sb1, sb2, sb3;
    QLabel sb_label1, sb_label2, sb_label3;
    sb_label1.setText("Input1");
    sb_label2.setText("Input2");
    sb_label3.setText("Input3");

    form_layout.addRow(&sb_label1, &sb1);
    form_layout.addRow(&sb_label2, &sb2);
    form_layout.addRow(&sb_label3, &sb3);

    form_layout.setFieldGrowthPolicy(QFormLayout::FieldsStayAtSizeHint);

    // Populating the upper right box with radio boxes
    QRadioButton rb1, rb2, rb3;
    rb1.setText("Option1");
    rb2.setText("Option2");
    rb3.setText("Option3");

    v_box_layout.addWidget(&rb1);
    v_box_layout.addWidget(&rb2);
    v_box_layout.addWidget(&rb3);
    
    // Adding a text edit in the central area
    QTextEdit text_edit;
    grid_layout.addWidget(&text_edit, 1, 0, 1, 2); // the edit stretches for two coloumns

    // Adding buttons in the lower right corner
    QPushButton pb1, pb2, pb3;
    pb1.setText("Button1");
    pb2.setText("Button2");
    pb3.setText("Button3");
    hor_box_layout.addStretch(20);
    hor_box_layout.addWidget(&pb1);
    hor_box_layout.addWidget(&pb2);
    hor_box_layout.addWidget(&pb3);

    widget.setWindowTitle("This is a test!");
    widget.resize(500, 400);

    widget.show();
    return app.exec();
}
