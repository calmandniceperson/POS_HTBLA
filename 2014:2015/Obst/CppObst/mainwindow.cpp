#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    connect(ui->categoryComboBox , SIGNAL(currentIndexChanged(int)),this,SLOT(handleProductSelectionChanged(int)));

    ui->categoryComboBox->addItem("Fruits");
    ui->categoryComboBox->addItem("Vegetables");
    ui->categoryComboBox->addItem("Fruit products");
}

MainWindow::~MainWindow()
{
    delete ui;
}

// clears the list of products on change in the category combobox
// and refills it with appropriate content
void MainWindow::handleProductSelectionChanged(int i){
    switch(i){
    case 0:
        ui->productComboBox->clear();
        ui->productComboBox->addItem("Apple");
        ui->productComboBox->addItem("Pear");
        ui->productComboBox->addItem("Orange");
        break;
    case 1:
        ui->productComboBox->clear();
        ui->productComboBox->addItem("Cucumber");
        ui->productComboBox->addItem("Tomato");
        ui->productComboBox->addItem("Pepper");
        break;
    case 2:
        ui->productComboBox->clear();
        ui->productComboBox->addItem("Apple juice");
        ui->productComboBox->addItem("Orange juice");
        break;
    }
}
