﻿namespace StackExchange.StacMan
{
    public partial class Filter
    {
        public static readonly Filter Default = new Filter
        {
            FilterName = "default",
            FilterType = Filters.FilterType.Safe,
            IncludedFields = new string[]
            {
                ".backoff",
                ".error_id",
                ".error_message",
                ".error_name",
                ".has_more",
                ".items",
                ".quota_max",
                ".quota_remaining",
                "access_token.access_token",
                "access_token.account_id",
                "access_token.expires_on_date",
                "access_token.scope",
                "answer.answer_id",
                "answer.community_owned_date",
                "answer.creation_date",
                "answer.is_accepted",
                "answer.last_activity_date",
                "answer.last_edit_date",
                "answer.locked_date",
                "answer.owner",
                "answer.question_id",
                "answer.score",
                "badge.award_count",
                "badge.badge_id",
                "badge.badge_type",
                "badge.link",
                "badge.name",
                "badge.rank",
                "badge.user",
                "badge_count.bronze",
                "badge_count.gold",
                "badge_count.silver",
                "comment.comment_id",
                "comment.creation_date",
                "comment.edited",
                "comment.owner",
                "comment.post_id",
                "comment.reply_to_user",
                "comment.score",
                "error.description",
                "error.error_id",
                "error.error_name",
                "event.creation_date",
                "event.event_id",
                "event.event_type",
                "filter.filter",
                "filter.filter_type",
                "filter.included_fields",
                "inbox_item.answer_id",
                "inbox_item.comment_id",
                "inbox_item.creation_date",
                "inbox_item.is_unread",
                "inbox_item.item_type",
                "inbox_item.link",
                "inbox_item.question_id",
                "inbox_item.site",
                "inbox_item.title",
                "info.answers_per_minute",
                "info.api_revision",
                "info.badges_per_minute",
                "info.new_active_users",
                "info.questions_per_minute",
                "info.total_accepted",
                "info.total_answers",
                "info.total_badges",
                "info.total_comments",
                "info.total_questions",
                "info.total_unanswered",
                "info.total_users",
                "info.total_votes",
                "migration_info.on_date",
                "migration_info.other_site",
                "migration_info.question_id",
                "network_user.account_id",
                "network_user.answer_count",
                "network_user.badge_counts",
                "network_user.creation_date",
                "network_user.last_access_date",
                "network_user.question_count",
                "network_user.reputation",
                "network_user.site_name",
                "network_user.site_url",
                "network_user.user_id",
                "post.creation_date",
                "post.last_activity_date",
                "post.last_edit_date",
                "post.owner",
                "post.post_id",
                "post.post_type",
                "post.score",
                "privilege.description",
                "privilege.reputation",
                "privilege.short_description",
                "question.accepted_answer_id",
                "question.answer_count",
                "question.bounty_amount",
                "question.bounty_closes_date",
                "question.closed_date",
                "question.closed_reason",
                "question.community_owned_date",
                "question.creation_date",
                "question.is_answered",
                "question.last_activity_date",
                "question.last_edit_date",
                "question.link",
                "question.locked_date",
                "question.migrated_from",
                "question.migrated_to",
                "question.owner",
                "question.protected_date",
                "question.question_id",
                "question.score",
                "question.tags",
                "question.title",
                "question.view_count",
                "question_timeline.comment_id",
                "question_timeline.creation_date",
                "question_timeline.down_vote_count",
                "question_timeline.owner",
                "question_timeline.post_id",
                "question_timeline.question_id",
                "question_timeline.revision_guid",
                "question_timeline.timeline_type",
                "question_timeline.up_vote_count",
                "question_timeline.user",
                "related_site.api_site_parameter",
                "related_site.name",
                "related_site.relation",
                "related_site.site_url",
                "reputation.on_date",
                "reputation.post_id",
                "reputation.post_type",
                "reputation.reputation_change",
                "reputation.user_id",
                "reputation.vote_type",
                "revision.comment",
                "revision.creation_date",
                "revision.is_rollback",
                "revision.last_tags",
                "revision.last_title",
                "revision.post_id",
                "revision.post_type",
                "revision.revision_guid",
                "revision.revision_number",
                "revision.revision_type",
                "revision.set_community_wiki",
                "revision.tags",
                "revision.title",
                "revision.user",
                "shallow_user.accept_rate",
                "shallow_user.display_name",
                "shallow_user.link",
                "shallow_user.profile_image",
                "shallow_user.reputation",
                "shallow_user.user_id",
                "shallow_user.user_type",
                "site.aliases",
                "site.api_site_parameter",
                "site.audience",
                "site.closed_beta_date",
                "site.favicon_url",
                "site.icon_url",
                "site.launch_date",
                "site.logo_url",
                "site.markdown_extensions",
                "site.name",
                "site.open_beta_date",
                "site.related_sites",
                "site.site_state",
                "site.site_type",
                "site.site_url",
                "site.styling",
                "site.twitter_account",
                "styling.link_color",
                "styling.tag_background_color",
                "styling.tag_foreground_color",
                "suggested_edit.approval_date",
                "suggested_edit.comment",
                "suggested_edit.creation_date",
                "suggested_edit.post_id",
                "suggested_edit.post_type",
                "suggested_edit.proposing_user",
                "suggested_edit.rejection_date",
                "suggested_edit.suggested_edit_id",
                "suggested_edit.tags",
                "suggested_edit.title",
                "tag.count",
                "tag.has_synonyms",
                "tag.is_moderator_only",
                "tag.is_required",
                "tag.name",
                "tag.user_id",
                "tag_score.post_count",
                "tag_score.score",
                "tag_score.user",
                "tag_synonym.applied_count",
                "tag_synonym.creation_date",
                "tag_synonym.from_tag",
                "tag_synonym.last_applied_date",
                "tag_synonym.to_tag",
                "tag_wiki.body_last_edit_date",
                "tag_wiki.excerpt",
                "tag_wiki.excerpt_last_edit_date",
                "tag_wiki.tag_name",
                "top_tag.answer_count",
                "top_tag.answer_score",
                "top_tag.question_count",
                "top_tag.question_score",
                "top_tag.tag_name",
                "user.accept_rate",
                "user.account_id",
                "user.age",
                "user.badge_counts",
                "user.creation_date",
                "user.display_name",
                "user.is_employee",
                "user.last_access_date",
                "user.last_modified_date",
                "user.link",
                "user.location",
                "user.profile_image",
                "user.reputation",
                "user.reputation_change_day",
                "user.reputation_change_month",
                "user.reputation_change_quarter",
                "user.reputation_change_week",
                "user.reputation_change_year",
                "user.timed_penalty_date",
                "user.user_id",
                "user.user_type",
                "user.website_url",
                "user_timeline.badge_id",
                "user_timeline.comment_id",
                "user_timeline.creation_date",
                "user_timeline.detail",
                "user_timeline.post_id",
                "user_timeline.post_type",
                "user_timeline.suggested_edit_id",
                "user_timeline.timeline_type",
                "user_timeline.title",
                "user_timeline.user_id",
            }
        };

        public static readonly Filter WithBody = new Filter
        {
            FilterName = "withbody",
            FilterType = Filters.FilterType.Safe,
            IncludedFields = new string[]
            {
                ".backoff",
                ".error_id",
                ".error_message",
                ".error_name",
                ".has_more",
                ".items",
                ".quota_max",
                ".quota_remaining",
                "access_token.access_token",
                "access_token.account_id",
                "access_token.expires_on_date",
                "access_token.scope",
                "answer.answer_id",
                "answer.body",
                "answer.community_owned_date",
                "answer.creation_date",
                "answer.is_accepted",
                "answer.last_activity_date",
                "answer.last_edit_date",
                "answer.locked_date",
                "answer.owner",
                "answer.question_id",
                "answer.score",
                "badge.award_count",
                "badge.badge_id",
                "badge.badge_type",
                "badge.link",
                "badge.name",
                "badge.rank",
                "badge.user",
                "badge_count.bronze",
                "badge_count.gold",
                "badge_count.silver",
                "comment.body",
                "comment.comment_id",
                "comment.creation_date",
                "comment.edited",
                "comment.owner",
                "comment.post_id",
                "comment.reply_to_user",
                "comment.score",
                "error.description",
                "error.error_id",
                "error.error_name",
                "event.creation_date",
                "event.event_id",
                "event.event_type",
                "filter.filter",
                "filter.filter_type",
                "filter.included_fields",
                "inbox_item.answer_id",
                "inbox_item.body",
                "inbox_item.comment_id",
                "inbox_item.creation_date",
                "inbox_item.is_unread",
                "inbox_item.item_type",
                "inbox_item.link",
                "inbox_item.question_id",
                "inbox_item.site",
                "inbox_item.title",
                "info.answers_per_minute",
                "info.api_revision",
                "info.badges_per_minute",
                "info.new_active_users",
                "info.questions_per_minute",
                "info.total_accepted",
                "info.total_answers",
                "info.total_badges",
                "info.total_comments",
                "info.total_questions",
                "info.total_unanswered",
                "info.total_users",
                "info.total_votes",
                "migration_info.on_date",
                "migration_info.other_site",
                "migration_info.question_id",
                "network_user.account_id",
                "network_user.answer_count",
                "network_user.badge_counts",
                "network_user.creation_date",
                "network_user.last_access_date",
                "network_user.question_count",
                "network_user.reputation",
                "network_user.site_name",
                "network_user.site_url",
                "network_user.user_id",
                "post.body",
                "post.creation_date",
                "post.last_activity_date",
                "post.last_edit_date",
                "post.owner",
                "post.post_id",
                "post.post_type",
                "post.score",
                "privilege.description",
                "privilege.reputation",
                "privilege.short_description",
                "question.accepted_answer_id",
                "question.answer_count",
                "question.body",
                "question.bounty_amount",
                "question.bounty_closes_date",
                "question.closed_date",
                "question.closed_reason",
                "question.community_owned_date",
                "question.creation_date",
                "question.is_answered",
                "question.last_activity_date",
                "question.last_edit_date",
                "question.link",
                "question.locked_date",
                "question.migrated_from",
                "question.migrated_to",
                "question.owner",
                "question.protected_date",
                "question.question_id",
                "question.score",
                "question.tags",
                "question.title",
                "question.view_count",
                "question_timeline.comment_id",
                "question_timeline.creation_date",
                "question_timeline.down_vote_count",
                "question_timeline.owner",
                "question_timeline.post_id",
                "question_timeline.question_id",
                "question_timeline.revision_guid",
                "question_timeline.timeline_type",
                "question_timeline.up_vote_count",
                "question_timeline.user",
                "related_site.api_site_parameter",
                "related_site.name",
                "related_site.relation",
                "related_site.site_url",
                "reputation.on_date",
                "reputation.post_id",
                "reputation.post_type",
                "reputation.reputation_change",
                "reputation.user_id",
                "reputation.vote_type",
                "revision.body",
                "revision.comment",
                "revision.creation_date",
                "revision.is_rollback",
                "revision.last_tags",
                "revision.last_title",
                "revision.post_id",
                "revision.post_type",
                "revision.revision_guid",
                "revision.revision_number",
                "revision.revision_type",
                "revision.set_community_wiki",
                "revision.tags",
                "revision.title",
                "revision.user",
                "shallow_user.accept_rate",
                "shallow_user.display_name",
                "shallow_user.link",
                "shallow_user.profile_image",
                "shallow_user.reputation",
                "shallow_user.user_id",
                "shallow_user.user_type",
                "site.aliases",
                "site.api_site_parameter",
                "site.audience",
                "site.closed_beta_date",
                "site.favicon_url",
                "site.icon_url",
                "site.launch_date",
                "site.logo_url",
                "site.markdown_extensions",
                "site.name",
                "site.open_beta_date",
                "site.related_sites",
                "site.site_state",
                "site.site_type",
                "site.site_url",
                "site.styling",
                "site.twitter_account",
                "styling.link_color",
                "styling.tag_background_color",
                "styling.tag_foreground_color",
                "suggested_edit.approval_date",
                "suggested_edit.body",
                "suggested_edit.comment",
                "suggested_edit.creation_date",
                "suggested_edit.post_id",
                "suggested_edit.post_type",
                "suggested_edit.proposing_user",
                "suggested_edit.rejection_date",
                "suggested_edit.suggested_edit_id",
                "suggested_edit.tags",
                "suggested_edit.title",
                "tag.count",
                "tag.has_synonyms",
                "tag.is_moderator_only",
                "tag.is_required",
                "tag.name",
                "tag.user_id",
                "tag_score.post_count",
                "tag_score.score",
                "tag_score.user",
                "tag_synonym.applied_count",
                "tag_synonym.creation_date",
                "tag_synonym.from_tag",
                "tag_synonym.last_applied_date",
                "tag_synonym.to_tag",
                "tag_wiki.body",
                "tag_wiki.body_last_edit_date",
                "tag_wiki.excerpt",
                "tag_wiki.excerpt_last_edit_date",
                "tag_wiki.tag_name",
                "top_tag.answer_count",
                "top_tag.answer_score",
                "top_tag.question_count",
                "top_tag.question_score",
                "top_tag.tag_name",
                "user.accept_rate",
                "user.account_id",
                "user.age",
                "user.badge_counts",
                "user.creation_date",
                "user.display_name",
                "user.is_employee",
                "user.last_access_date",
                "user.last_modified_date",
                "user.link",
                "user.location",
                "user.profile_image",
                "user.reputation",
                "user.reputation_change_day",
                "user.reputation_change_month",
                "user.reputation_change_quarter",
                "user.reputation_change_week",
                "user.reputation_change_year",
                "user.timed_penalty_date",
                "user.user_id",
                "user.user_type",
                "user.website_url",
                "user_timeline.badge_id",
                "user_timeline.comment_id",
                "user_timeline.creation_date",
                "user_timeline.detail",
                "user_timeline.post_id",
                "user_timeline.post_type",
                "user_timeline.suggested_edit_id",
                "user_timeline.timeline_type",
                "user_timeline.title",
                "user_timeline.user_id",
            }
        };

        public static readonly Filter None = new Filter
        {
            FilterName = "none",
            FilterType = Filters.FilterType.Safe,
            IncludedFields = new string[0]
        };

        public static readonly Filter Total = new Filter
        {
            FilterName = "total",
            FilterType = Filters.FilterType.Safe,
            IncludedFields = new string[]
            {
                ".total"
            }
        };
    }
}
