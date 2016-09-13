void MainWindow::ShowWeightData()
{
    int row = ui->tblWeight->currentIndex().row();
    cout<<"Row = "<<row<<endl;

    QSqlRecord currRec = WeightsModel->record(row);

    QSqlQuery query;
    QString str_insert = "SELECT PHOTO1, PHOTO2 FROM weights WHERE WEIGHT_ID is %1;";
    int id = currRec.value("WEIGHT_ID").toInt();

    QString str = str_insert.arg(id);

    bool ret = query.exec(str);

    if(!ret)
    {
        QMessageBox msgBox;
        msgBox.setText(tr("Проблема с запросом к таблице взвешиваний"));
        msgBox.exec();
    }


    if(query.isSelect())
    {
        query.first();

        QPixmap pix1, pix2;

        ret = pix1.loadFromData(QByteArray::fromBase64(query.value(0).toByteArray()));
        if(ret)
        {
            ui->Cam1_Weight->setPixmap(pix1);

        }

        ret = pix2.loadFromData(QByteArray::fromBase64(query.value(1).toByteArray()));
        if(ret)
        {
            ui->Cam2_Weight->setPixmap(pix2);
        }
        ui->lcdWeight_2->display(currRec.value("WEIGHT").toInt());
    }
    else
    {
        QMessageBox msgBox;
        msgBox.setText(tr("Проблема при загрузке фотографий из таблицы взвешиваний"));
        msgBox.exec();
    }
}
