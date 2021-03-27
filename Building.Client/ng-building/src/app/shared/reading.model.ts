import { Timestamp } from "rxjs";

export class Reading {
    buildingId: number=0;
    dataFieldId: number=0;
    objectId: number=0;
    value: number=0.0;
    timestamp: Date = new Date();
}

export class ReadingVm{
    buildingId: number=0;
    dataFieldId: number=0;
    objectId: number=0;
    timestampFrom: Date | undefined;
    timestampTo: Date | undefined;
}
