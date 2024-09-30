import { ObjectType, Field } from "@nestjs/graphql";
import { ApiProperty } from "@nestjs/swagger";
import { Type } from "class-transformer";
import { GraphQLJSON } from "graphql-type-json";
import { InputJsonValue } from "../types";
import { EnumPacakgeStatus } from "./EnumPacakgeStatus";

@ObjectType("PackageObject")
class Package {
    @Field(() => String)
    @ApiProperty({
        required: true,
        type: () => String
    })
    @Type(() => String)
    id!: string;

    @Field(() => GraphQLJSON)
    name!: InputJsonValue;

    @Field(() => EnumPacakgeStatus)
    @ApiProperty({
        required: true,
        enum: EnumPacakgeStatus
    })
    status!: "pending" | "running" | "failed" | "completed";
}

export { Package as Package };