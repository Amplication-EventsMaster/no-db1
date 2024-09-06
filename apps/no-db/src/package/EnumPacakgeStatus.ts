import { registerEnumType } from "@nestjs/graphql";

export enum EnumPacakgeStatus {
    Pending = "pending",
    Running = "running",
    Failed = "failed",
    Completed = "completed"
}

registerEnumType(EnumPacakgeStatus, {
    name: "EnumPacakgeStatus",
  });