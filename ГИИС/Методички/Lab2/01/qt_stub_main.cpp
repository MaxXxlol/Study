
#include <QApplication>
#include <QWidget>

int main (int argc, char **argv)
{
    QApplication app(argc, argv);
    QWidget widget(0);

    widget.show();
    return app.exec();
}
