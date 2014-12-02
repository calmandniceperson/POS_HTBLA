#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{

    //creates the main window
    ui->setupUi(this);

    connect(ui->categoryComboBox , SIGNAL(currentIndexChanged(int)),this,SLOT(handleProductSelectionChanged(int)));

    ui->productList->hide();

    //set text for the tabs at the top
    ui->tabWidget->setTabText(0, "Hardware");
    ui->tabWidget->setTabText(1, "Services");

    //add items to the category selection dropdown menu
    ui->categoryComboBox->addItem("Graphics cards");
    ui->categoryComboBox->addItem("Storage");
    ui->categoryComboBox->addItem("Keyboards");


}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::handleProductSelectionChanged(int i){
    switch(i){
    case 0:
        ui->productList->clear();

        ui->productList->show();

        ui->productList->addItem("NVIDIA GeForce GTX 660 Ti");
        ui->productList->addItem("Intel HD Family 4000");
        break;
    case 1:
        ui->productList->clear();

        if(!ui->productList->isVisible()){
            ui->productList->show();
        }

        ui->productList->addItem("NVIDIA GeForce GTX 660 Ti");
        ui->productList->addItem("Intel HD Family 4000");
        break;
    case 2:
        break;
    }
}
